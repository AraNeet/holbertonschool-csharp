namespace InventoryLibrary
{
    public class Item : BaseClass
    {
        public string Name { get; set; }
        public string? Description { get; set; }
        private float _price;

        public float Price
        {
            get => _price;
            set => _price = (float)Math.Round(value, 2);
        }

        public List<string> Tags { get; set; } = new List<string>();

        public Item(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Name is required.", nameof(name));
            }
            Name = name;
        }
    }
}