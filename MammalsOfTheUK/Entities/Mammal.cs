using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class Mammal
    {
        public int MammalID { get; set; }
        
        [StringLength(1000)]
        public string Description { get; set; } = string.Empty; // to avoid NullReferenceException. 
        
        [StringLength(120)]
        public string Image { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Common Name")]
        public string CommonName { get; set; } = string.Empty;
        
        [Required]
        [StringLength(50)]
        [Display(Name = "Scientific Name")]
        public string ScientificName { get; set; } = string.Empty;
        
        [StringLength(50)]
        public string Family { get; set; } = string.Empty;
        
        [StringLength(255)]
        public string Habitat { get; set; } = string.Empty;
        
        [StringLength(255)]
        public string Diet { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string Origin { get; set; } = string.Empty;
        
        [StringLength(100)]
        public string Predators { get; set; } = string.Empty;
        
        [StringLength(1000)]
        [Display(Name = "Looks Like")]
        public string LooksLike { get; set; } = string.Empty;
    }
}
