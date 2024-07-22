using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class RiskCategory
    {
        public int MammalID { get; set; }

        // If the Risk Level might not be set for certain country
        // nullable RiskLevel (RiskLevel?) will handle cases where the value is not applicable.
        public RiskLevel? England { get; set; }

        public RiskLevel? Wales { get; set; }

        public RiskLevel? Scotland { get; set; }

        [Display(Name = "Northern Ireland")]
        public RiskLevel? NorthernIreland { get; set; }

    }
}
