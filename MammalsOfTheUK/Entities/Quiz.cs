
/* <summary>
   Represents a Quiz entity with a unique identifier.
   Author: Eduardo
   Last Modified: 25/07/2024
*/

using System.ComponentModel.DataAnnotations; // Import DataAnnotations for validation and metadata

namespace MammalsOfTheUK.Entities
{
    // Represents a Quiz entity
    public class Quiz
    {
        // Unique identifier for the Quiz
        // This ID is used to uniquely identify each quiz instance
        public int QuizID { get; set; }
    }
}