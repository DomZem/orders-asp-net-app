namespace orders_asp_net_app.Models
{
    public enum ProductCategory
    {
        ELECTRONICS,
        FASHION,
        HEALTH,
        ENTERTAINMENT,
        SPORT
    }

    public class Product
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Description { get; set; }

        public decimal Price { get; set; } 
        
        public decimal Weight { get; set; }

        public int Quantity { get; set; } 

        public ProductCategory Category { get; set; }
    }
}
