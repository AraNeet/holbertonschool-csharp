namespace InventoryLibrary
{
    public class User : BaseClass
    {
        public string Name { get; set; }

        public User(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required.", nameof(name));
            }
            Name = name;
        }
    }
}