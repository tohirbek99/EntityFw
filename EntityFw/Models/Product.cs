using System.ComponentModel.DataAnnotations;

namespace EntityFw.Models
{
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public List<ProductTranslate> ProductTranslates { get; set; }=new List<ProductTranslate>();
        public List<Order_Details> Order_Details { get; set; }

    }
}
