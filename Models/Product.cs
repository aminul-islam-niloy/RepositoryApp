using System.ComponentModel.DataAnnotations;

namespace RepositoryApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="please inter item name ")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Enter product description")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Select product Category")]
        public string Category { get; set; }
        [Required(ErrorMessage ="Product Price")]
        public decimal Price { get; set; }
    }
}
