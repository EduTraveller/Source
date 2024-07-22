using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class Quiz
    {
        [Range(1, 11)]
        public int QuizID { get; set; }
    }
}
