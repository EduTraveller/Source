using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a User entity
    public class User
    {
        // Unique identifier for the user
        // This ID is used to uniquely identify each user
        public int UserID { get; set; }
    }
}

// Author: Eduardo
// Last Modified: 22/07/2024