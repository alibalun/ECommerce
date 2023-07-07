using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Category
    {
        
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Lütfen kategori adı giriniz!!")]
        public string CategoryName { get; set; }
        // Reference navigation properties
        public ICollection<SubCategory>? SubCategories { get; set; }
        public ICollection<Product>? Products { get; set; } 

    }
}
