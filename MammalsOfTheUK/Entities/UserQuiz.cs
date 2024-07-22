using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class UserQuiz
    {
        [Range(1, 11)]
        public int UserID { get; set; }
        
        [Range(1, 11)]
        public int QuizID { get; set; }
        
        [Required]
        [Display(Name = "Date of Quiz")]
        public DateTime DateOfQuiz { get; set; }
    }
}
