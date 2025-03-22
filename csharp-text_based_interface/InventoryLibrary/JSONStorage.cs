using System.Text.Json;

namespace InventoryLibrary;

public class JSONStorage
{
  private const string FilePath = "../storage/inventory_manager.json";
  public Dictionary<string, object> Objects {get; private set; } = new Dictionary<string, object>();
  
  public Dictionary<string, object> All()
  {
    return Objects;
  }

  public void New(object obj)
  {
    var className = obj.GetType().Name;
    var idProperty = obj.GetType().GetProperty("Id");
    if (idProperty == null)
    {
      throw new ArgumentException("Object must have an Id property.");
    }

    var id = idProperty.GetValue(obj)?.ToString();
    if (string.IsNullOrWhiteSpace(id))
    {
      throw new ArgumentException("Object Id cannot be null or empty.");
    }

    var key = $"{className}.{id}";
    Objects[key] = obj;
  }

  public void Save()
  {
    var options = new JsonSerializerOptions { WriteIndented = true };
    var json = JsonSerializer.Serialize(Objects, options);
    Directory.CreateDirectory(Path.GetDirectoryName(FilePath));
    File.WriteAllText(FilePath, json);
  }

  public void Load()
  {
    if (File.Exists(FilePath))
    {
      var json = File.ReadAllText(FilePath);
      Objects = JsonSerializer.Deserialize<Dictionary<string, object>>(json) ?? new Dictionary<string, object>();
    }
  }
}