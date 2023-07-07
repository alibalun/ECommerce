using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class ProductOrder
    {
        [Key]
        public int Id { get; set; }
        // Reference navigation properties
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Order Order { get; set; }
        public int OrderId { get; set; }
    }
}
