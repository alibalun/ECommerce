using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen isim giriniz!!")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "Lütfen bir soyisim giriniz!!")]
        public string CustomerSurname { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Lütfen bir mail giriniz!!")]
        public string CustomerEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Lütfen bir telefon numarası giriniz!!")]
        public string CustomerPhone { get; set; }

        // Reference navigation properties

        public ICollection<CustomerAddress>? Addresses { get; set; }
        public ICollection<Order>? Orders { get; set; }

    }
}
