using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LectureRegistrationSystem.Data.Models
{
    public class LectureRegister
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { set; get; }
        [Required]
        [Column("User")]
        public User UserId { get; set; }
        [Required]
        [Column("Lecture")]
        public LectureSchedule LectureId { get; set; }
    }
}
