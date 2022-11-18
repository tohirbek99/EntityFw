using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFw.Models
{
    public class OrderTranslate
    {
        [Key]
        public int OrderTranslateId { get; set; }
        public string? ShipDate { get; set; }
        public string? ShipAddress { get; set; }
        public string? ShipCity { get; set; }
        [ForeignKey("Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }
        [ForeignKey("Language")]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
    }
}
