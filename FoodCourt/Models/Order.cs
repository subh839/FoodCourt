namespace FoodCourt.Models
{
    public class Order
    {
        public int OrderId { get; set; }    
        public DateTime OrderDate { get; set; }
        public string UserId { get; set; }
        public ApplicationUser user { get; set; }

        public decimal TotalAmount { get; set; }    

        public ICollection<OrderItem> OrderItems { get; set; } 
    }
}
