using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LectureRegistrationSystem.Data.Models
{
    public class Lecture
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("lecture")]
        public string LectureName { get; set; }
        [Required]
        [Column("faculty_id")]
        public Faculty FacultyId { get; set; }
        [Required]
        [Column("Level_of_studies")]
        [MinLength(3), MaxLength(70)]
        public string LevelOfStudies { get; set; }
        [Required]
        [Column("study_program_id")]
        public StudyProgram StudyProgramId { get; set; }
        [Required]
        [Column("study_year_id")]
        public int StudyYear { get; set; }
    }
}
