using System.ComponentModel.DataAnnotations;

namespace AnimalShelter.Models
{
    public class Animal
    {
        [Required]
        public int AnimalId { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        public string Breed { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public int Price { get; set; }
    }
}