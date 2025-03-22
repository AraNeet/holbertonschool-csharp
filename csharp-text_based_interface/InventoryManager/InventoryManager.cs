using InventoryLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class InventoryManager
{
  private JSONStorage store;

  public InventoryManager()
  {
    store = new JSONStorage();
    store.Load();
  }

  public void Run()
  {
    Console.WriteLine("Inventory Manager");
    PrintPrompt();

    bool running = true;
    while (running)
    {
      Console.Write("$ ");
      string? input = Console.ReadLine()?.Trim().ToLower();
      
      if (string.IsNullOrEmpty(input))
        continue;
      
      string[] arguments = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
      
      switch (arguments[0])
      {
        case "classnames":
          PrintClassNames();
          break;
        
        case "all":
          if (arguments.Length == 1)
            PrintAll();
          else if (arguments.Length == 2)
            PrintAllOfClass(arguments[1]);
          else
            Console.WriteLine("Usage: All [ClassName]");
          break;
        
        case "create":
          if (arguments.Length == 2)
            CreateObject(arguments[1]);
          else
            Console.WriteLine("Usage: Create <ClassName>");
          break;
        
        case "show":
          if (arguments.Length == 3)
            ShowObject(arguments[1], arguments[2]);
          else
            Console.WriteLine("Usage: Show <ClassName> <id>");
          break;
        
        case "update":
          if (arguments.Length == 3)
            UpdateObject(arguments[1], arguments[2]);
          else
            Console.WriteLine("Usage: Update <ClassName> <id>");
          break;
        
        case "delete":
          if (arguments.Length == 3)
            DeleteObject(arguments[1], arguments[2]);
          else
            Console.WriteLine("Usage: Delete <ClassName> <id>");
          break;
        
        case "exit":
          running = false;
          continue;
        
        default:
          Console.WriteLine("Unknown command. Please try again.");
          break;
      }
      
      if (running)
        PrintPrompt();
    }
  }

  private void PrintPrompt()
  {
    Console.WriteLine("\nAvailable commands:");
    Console.WriteLine("  ClassNames");
    Console.WriteLine("  All");
    Console.WriteLine("  All <ClassName>");
    Console.WriteLine("  Create <ClassName>");
    Console.WriteLine("  Show <ClassName> <id>");
    Console.WriteLine("  Update <ClassName> <id>");
    Console.WriteLine("  Delete <ClassName> <id>");
    Console.WriteLine("  Exit");
    Console.WriteLine();
  }

  private void PrintClassNames()
  {
    HashSet<string> classNames = new HashSet<string>();
    foreach (var key in store.All().Keys)
    {
      string className = key.Split('.')[0];
      classNames.Add(className);
    }

    if (classNames.Count == 0)
    {
      Console.WriteLine("No classes found.");
      return;
    }

    foreach (var className in classNames)
    {
      Console.WriteLine(className);
    }
  }

  private void PrintAll()
  {
    if (store.All().Count == 0)
    {
      Console.WriteLine("No objects found.");
      return;
    }

    foreach (var pair in store.All())
    {
      Console.WriteLine($"{pair.Key}: {pair.Value}");
    }
  }

  private void PrintAllOfClass(string className)
  {
    Type? type = GetTypeByName(className);
    if (type == null)
    {
      Console.WriteLine($"{className} is not a valid object type");
      return;
    }

    bool found = false;
    foreach (var pair in store.All())
    {
      if (pair.Key.StartsWith($"{className}.", StringComparison.OrdinalIgnoreCase))
      {
        Console.WriteLine($"{pair.Key}: {pair.Value}");
        found = true;
      }
    }

    if (!found)
    {
      Console.WriteLine($"No objects of type {className} found.");
    }
  }

  private void CreateObject(string className)
  {
    Type? type = GetTypeByName(className);
    if (type == null)
    {
      Console.WriteLine($"{className} is not a valid object type");
      return;
    }

    try
    {
      object? obj = null;
      
      if (type == typeof(Item))
      {
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
          Console.WriteLine("Name is required.");
          return;
        }
        
        Item item = new Item(name);
        
        Console.Write("Description (optional): ");
        string? description = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(description))
          item.Description = description;
        
        Console.Write("Price (optional): ");
        string? priceStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(priceStr) && float.TryParse(priceStr, out float price))
          item.Price = price;
        
        Console.Write("Tags (comma-separated, optional): ");
        string? tagsStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(tagsStr))
        {
          string[] tags = tagsStr.Split(',', StringSplitOptions.RemoveEmptyEntries);
          foreach (var tag in tags)
            item.Tags.Add(tag.Trim());
        }
        
        obj = item;
      }
      else if (type == typeof(User))
      {
        Console.Write("Name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
          Console.WriteLine("Name is required.");
          return;
        }
        
        obj = new User(name);
      }
      else if (type == typeof(Inventory))
      {
        Console.Write("User ID: ");
        string? userId = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(userId))
        {
          Console.WriteLine("User ID is required.");
          return;
        }
        
        Console.Write("Item ID: ");
        string? itemId = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(itemId))
        {
          Console.WriteLine("Item ID is required.");
          return;
        }
        
        Inventory inventory = new Inventory(userId, itemId);
        
        Console.Write("Quantity (default: 1): ");
        string? quantityStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(quantityStr) && int.TryParse(quantityStr, out int quantity))
          inventory.Quantity = quantity;
        
        obj = inventory;
      }
      
      if (obj != null)
      {
        store.New(obj);
        store.Save();
        Console.WriteLine($"{className} created successfully.");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error creating {className}: {ex.Message}");
    }
  }

  private void ShowObject(string className, string id)
  {
    Type? type = GetTypeByName(className);
    if (type == null)
    {
      Console.WriteLine($"{className} is not a valid object type");
      return;
    }

    string key = $"{className}.{id}";
    if (!store.All().ContainsKey(key))
    {
      Console.WriteLine($"Object {id} could not be found");
      return;
    }

    Console.WriteLine($"{key}: {store.All()[key]}");
  }

  private void UpdateObject(string className, string id)
  {
    Type? type = GetTypeByName(className);
    if (type == null)
    {
      Console.WriteLine($"{className} is not a valid object type");
      return;
    }

    string key = $"{className}.{id}";
    if (!store.All().ContainsKey(key))
    {
      Console.WriteLine($"Object {id} could not be found");
      return;
    }

    object obj = store.All()[key];
    
    try
    {
      if (obj is Item item)
      {
        Console.Write($"Name [{item.Name}]: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
          item.Name = name;
        
        Console.Write($"Description [{item.Description}]: ");
        string? description = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(description))
          item.Description = description;
        
        Console.Write($"Price [{item.Price}]: ");
        string? priceStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(priceStr) && float.TryParse(priceStr, out float price))
          item.Price = price;
        
        Console.Write($"Tags [{string.Join(", ", item.Tags)}]: ");
        string? tagsStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(tagsStr))
        {
          item.Tags.Clear();
          string[] tags = tagsStr.Split(',', StringSplitOptions.RemoveEmptyEntries);
          foreach (var tag in tags)
            item.Tags.Add(tag.Trim());
        }
      }
      else if (obj is User user)
      {
        Console.Write($"Name [{user.Name}]: ");
        string? name = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(name))
          user.Name = name;
      }
      else if (obj is Inventory inventory)
      {
        Console.Write($"User ID [{inventory.UserId}]: ");
        string? userId = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(userId))
          inventory.UserId = userId;
        
        Console.Write($"Item ID [{inventory.ItemId}]: ");
        string? itemId = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(itemId))
          inventory.ItemId = itemId;
        
        Console.Write($"Quantity [{inventory.Quantity}]: ");
        string? quantityStr = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(quantityStr) && int.TryParse(quantityStr, out int quantity))
          inventory.Quantity = quantity;
      }
      
      PropertyInfo? dateUpdatedProperty = obj.GetType().GetProperty("DateUpdated");
      if (dateUpdatedProperty != null)
      {
        dateUpdatedProperty.SetValue(obj, DateTime.Now);
      }
      
      store.Save();
      Console.WriteLine($"{className} updated successfully.");
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error updating {className}: {ex.Message}");
    }
  }

  private void DeleteObject(string className, string id)
  {
    Type? type = GetTypeByName(className);
    if (type == null)
    {
      Console.WriteLine($"{className} is not a valid object type");
      return;
    }

    string key = $"{className}.{id}";
    if (!store.All().ContainsKey(key))
    {
      Console.WriteLine($"Object {id} could not be found");
      return;
    }

    store.All().Remove(key);
    store.Save();
    Console.WriteLine($"{className} deleted successfully.");
  }

  private Type? GetTypeByName(string className)
  {
    return className.ToLower() switch
    {
      "item" => typeof(Item),
      "user" => typeof(User),
      "inventory" => typeof(Inventory),
      _ => null
    };
  }

  public static void Main(string[] args)
  {
    InventoryManager manager = new InventoryManager();
    manager.Run();
  }
}