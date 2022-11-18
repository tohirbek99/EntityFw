using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFw.Models
{
    public class Order_Details
    {
        [Key]
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int DisCount { get; set; }

        public Product Product { get; set; }

        public Order Order { get; set; }

    }
}
