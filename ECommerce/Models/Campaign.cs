using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Campaign
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen bir kampanya yüzdesi giriniz!!")]
        public int CampaignPercent { get; set; }
        [Required(ErrorMessage = "Lütfen bir kampanya adı giriniz!!")]
        public string CampaignName { get; set;}

        // Reference navigation properties
        public ICollection<Product>? Products { get; set; }
    }
}
