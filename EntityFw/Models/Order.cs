using System.ComponentModel.DataAnnotations;

namespace EntityFw.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime RequiredDate { get; set; }
        public DateTime ShippedDate { get; set; }
        public int ShipVie { get; set; }
        public decimal Price { get; set; }
        public string? ShipPostalCode { get; set; }

        public List<OrderTranslate> OrderTranslates { get; set; } = new List<OrderTranslate>();
        public List<Order_Details> Order_Details { get; set; }

    }
}
