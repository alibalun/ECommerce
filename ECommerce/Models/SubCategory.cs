using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen alt kategori adı giriniz!!")]
        public string SubCategoryName { get; set; }

        // Reference navigation properties
        public Category Category { get; set; }
        public int CategoryId {get;set;}

        public ICollection<Product>? Products { get; set; }
    }
}
