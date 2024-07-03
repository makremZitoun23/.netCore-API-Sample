using System.ComponentModel.DataAnnotations;
using WebApplication1.Models.Validations;

namespace WebApplication1.Models
{
    public class Shirt
    {
        public int ShirtId { get; set; }
        [Required]
        public string? Brand { get; set; }


        //[Required]
        [Shirt_EnsureCorrectSizing]
        public string? Color { get; set; }

        [Required]
        public string? Gender { get; set; }

        public int Size{ get; set; }
        public double Price { get; set; }
    
    
    }
}
