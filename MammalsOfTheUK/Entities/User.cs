using System.ComponentModel.DataAnnotations;

namespace MammalsOfTheUK.Entities
{
    public class User
    {
        [Range(1, 11)]
        public int UserID { get; set; }
    }
}
