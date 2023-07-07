using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class CustomerAddress
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen bir şehir seçiniz!!")]
        public string City { get; set; }
        [Required(ErrorMessage = "Lütfen bir ilçe seçiniz!!")]
        public string Region { get; set; }
        [Required(ErrorMessage = "Lütfen bir mahalle seçiniz!!")]
        public string Street { get; set; }
        [Required(ErrorMessage = "Posta kodunu giriniz!!")]
        public string PostalCode { get; set; }
        [Required(ErrorMessage = "Adres tarifini yazınız.")]
        public string AddressDescription { get; set; }
        [Required(ErrorMessage = "Tam adresi yazınız.")]
        public string FullAddress { get; set; }
        
        // Reference navigation properties
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }

    }
}
