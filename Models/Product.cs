using System.ComponentModel.DataAnnotations;

namespace IsleworksWebApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int ProductTime { get; set; }
        public int ProductBaseValue { get; set; }

        public Product()
        {
            
        }
    }
}
