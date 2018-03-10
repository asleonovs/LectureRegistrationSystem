using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LectureRegistrationSystem.Data.Models
{
    public class LectureSchedule
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("date")]
        public DateTime Date { get; set; }
        [Required]
        [Column("lecture_id")]
        public Lecture LectureId { get; set; }
        [Required]
        [Column("study_program_id")]
        public StudyProgram StudyProgramId { get; set; }
    }
}
