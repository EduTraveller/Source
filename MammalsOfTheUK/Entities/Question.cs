using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class Question
    {
        public int QuestionID { get; set; }
        
        public int QuizID { get; set; }
        
        [StringLength(255)]
        [Display(Name = "Question Text")]
        public string QuestionText { get; set; } = string.Empty; // to avoid NullReferenceException. 
        
        [StringLength(100)]
        [Display(Name = "Option A")]
        public string OptionA { get; set; } = string.Empty; 
        
        [StringLength(100)]
        [Display(Name = "Option B")]
        public string OptionB { get; set; } = string.Empty; 
        
        [StringLength(100)]
        [Display(Name = "Option C")]
        public string OptionC { get; set; } = string.Empty; 
        
        [StringLength(100)]
        [Display(Name = "Option D")]
        public string OptionD { get; set; } = string.Empty; 
        
        [StringLength(255)]
        [Display(Name = "Correct Option")]
        public string CorrectOption { get; set; } = string.Empty; 
    }
}
