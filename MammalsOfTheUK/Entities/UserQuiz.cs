using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class UserQuiz
    {
        public int UserID { get; set; }
        
        public int QuizID { get; set; }
        
        [Required]
        [Display(Name = "Date of Quiz")]
        public DateTime DateOfQuiz { get; set; }
    }
}
