using System.ComponentModel.DataAnnotations;

namespace WebApiMorningClass.Models
{
    public class Shirt
    {
        public int Id { get; set; }
        [Required]
        public string? Brand {  get; set; }
        [Required]
        public string? Color {  get; set; }
        [Shirt_EnsureCorrectSizing]
        public int Size {  get; set; }
        [Required]
        public string? Gender {  get; set; }
        public double Price {  get; set; }
    }


}
