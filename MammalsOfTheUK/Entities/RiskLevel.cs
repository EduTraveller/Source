using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public enum RiskLevel
    {
        [Display(Name = "Least Concern")]
        LeastConcern = 1,
        
        [Display(Name = "Near Threatened")]
        NearThreatened = 2,
        
        Vulnerable = 3,
     
        Endangered = 4,
        
        [Display(Name = "Critically Endangered")]
        CriticallyEndangered = 5,
        
        [Display(Name = "Extinct in the Wild")]
        ExtinctInTheWild = 6,
        
        Extinct = 7
    }
}
