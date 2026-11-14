namespace _16_Web_Api.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required string Category { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPercentage { get; set; }
        public double Rating { get; set; }
        public int Stock { get; set; }
        public List<string> Tags { get; set; } = [];
        public required string Brand { get; set; }
        public required string Sku { get; set; }
        public decimal Weight { get; set; }
        public required string WarrantyInformation { get; set; }
        public required string ShippingInformation { get; set; }
        public required string AvailabilityInformation { get; set; }
        public required string ReturnPolicy { get; set; }
        public int MinimumOrderQuantity { get; set; }
        public required string Thumbnail { get; set; }
        public List<string> Images { get; set; } = [];
    }
}
