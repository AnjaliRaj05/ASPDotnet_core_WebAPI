namespace WebApp.Models
{
    public class Product
    {
        public int Id { get; set; } // Primary key

        public string? Name { get; set; }
        public int? Price { get; set; }
        public string? Description { get; set; }
    }
}
