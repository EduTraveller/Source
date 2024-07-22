using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class RiskCategory
    {
        [Range(1, 10)]
        public int MammalID { get; set; }
        
        [StringLength(7)]
        public string England { get; set; } = string.Empty;
        
        [StringLength(7)]
        public string Wales { get; set; } = string.Empty;
        
        [StringLength(7)]
        public string Scotland { get; set; } = string.Empty;
        
        [StringLength(7)]
        [Display(Name = "Northern Ireland")]
        public string NorthenIreland { get; set; } = string.Empty;
    }
}
