using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LectureRegistrationSystem.Data.Models
{
    public class Faculty
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("faculty")]
        public int FaculatyName { get; set; }
    }
}
