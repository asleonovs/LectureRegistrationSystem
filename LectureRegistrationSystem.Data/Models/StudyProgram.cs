using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LectureRegistrationSystem.Data.Models
{
    public class StudyProgram
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("Study_program")]
        public int StudyProgramName { get; set; }
    }
}
