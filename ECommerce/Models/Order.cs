using Microsoft.Identity.Client;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Sipriş durumunu seçiniz!")]
        public string OrderState { get; set; }
        [Required(ErrorMessage = "Sipariş tarih giriniz!!")]
        public string OrderDate { get; set; }
        [Required(ErrorMessage = "Sipariş açıklaması giriniz!!")]
        public string OrderDescription { get; set; }
        
        // Reference navigation properties
        public ICollection<ProductOrder> ProductOrders{ get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}
