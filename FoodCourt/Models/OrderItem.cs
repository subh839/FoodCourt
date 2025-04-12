using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace FoodCourt.Models
{
    public class OrderItem
    {
        [Key]
        public int OrederItemId { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}