namespace InventoryLibrary
{
    public class Inventory : BaseClass
    {
        public string UserId { get; set; }
        public string ItemId { get; set; }
        private int _quantity = 1;

        public int Quantity
        {
            get => _quantity;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Quantity cannot be less than 0.");
                }
                _quantity = value;
            }
        }

        public Inventory(string userId, string itemId)
        {
            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException("User ID is required.", nameof(userId));
            }
            if (string.IsNullOrWhiteSpace(itemId))
            {
                throw new ArgumentException("Item ID is required.", nameof(itemId));
            }
            UserId = userId;
            ItemId = itemId;
        }
    }
}