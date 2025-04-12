using System.ComponentModel.DataAnnotations.Schema;

namespace FoodCourt.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public IFormFile? ImageFile { get; set; }
        // hhtps file upload 
        public string ImageUrl { get; set; } = "https://via.placeholder.com/150";
        public int CategoryId { get; set; }

        public int Stock {  get; set; }
        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductIngredient> ProductIngredients { get; set; }
    }
}