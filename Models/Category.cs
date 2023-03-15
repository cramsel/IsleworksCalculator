using System.ComponentModel.DataAnnotations;

namespace IsleworksWebApp.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public string CategoryName { get; set; }

        public Category()
        {
            
        }
    }
}
