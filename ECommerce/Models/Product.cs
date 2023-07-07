using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adı giriniz!!")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Ürün fiyat giriniz!!")]
        public double ProductPrice { get; set; }
        [Required(ErrorMessage = "Ürün adeti giriniz!!")]
        public int ProductCount { get; set; }
        [Required(ErrorMessage = "Ürün açıklaması giriniz!!")]
        public string ProductDescription { get; set; }

        //Reference navigation properties
        public ICollection<ProductOrder>? ProductOrders { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public Campaign? Campaign { get; set; }
        public int? CampaignId { get; set;}
        public SubCategory? SubCategory { get; set; }
        public int SubCategoryId { get;set; }
    }
}
