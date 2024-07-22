using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a Risk Category entity, which classifies risk levels for mammals by Country
    public class RiskCategory
    {
        // Unique identifier for the mammal. This ID links the risk category to a specific mammal.
        public int MammalID { get; set; }

        // Risk level for the mammal in England. This is nullable to handle cases where the risk level might not be applicable.
        public RiskLevel? England { get; set; }

        // Risk level for the mammal in Wales. This is nullable to handle cases where the risk level might not be applicable.
        public RiskLevel? Wales { get; set; }

        // Risk level for the mammal in Scotland. This is nullable to handle cases where the risk level might not be applicable.
        public RiskLevel? Scotland { get; set; }

        // Risk level for the mammal in Northern Ireland. This is nullable to handle cases where the risk level might not be applicable.
        // Display name for UI purposes
        [Display(Name = "Northern Ireland")]
        public RiskLevel? NorthernIreland { get; set; }

    }
}

// Author: Eduardo
// Last Modified: 22/07/2024