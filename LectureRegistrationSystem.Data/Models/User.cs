using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LectureRegistrationSystem.Data.Models
{
    public class User
    {
        [Key]
        [Required]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("username"), MaxLength(50), MinLength(2)]
        public string Username { get; set; }
        [Required]
        [Column("password")]
        [MinLength(5), MaxLength(70)]
        public string Password { get; set; }
        [Required]
        [Column("name")]
        [MinLength(2), MaxLength(70)]
        public string Name { get; set; }
        [Required]
        [Column("surname")]
        [MinLength(2), MaxLength(70)]
        public string Surname { get; set; }
        [Required]
        [Column("email")]
        [MinLength(1), MaxLength(70)]
        public string Email { get; set; }
        [Required]
        [Column("role")]
        [MinLength(3), MaxLength(70)]
        public string Role { get; set; }
        [Required]
        [Column("faculty")]
        [MinLength(4), MaxLength(70)]
        public Faculty Faculty { get; set; }
        [Required]
        [Column("study_program")]
        [MinLength(3), MaxLength(70)]
        public StudyProgram StudyProgram { get; set; }
        [Required]
        [Column("Level_of_studies")]
        [MinLength(3), MaxLength(70)]
        public string LevelOfStudies { get; set; }
        [Required]
        [Column("year_of_study")]
        public int YearOfStudy { get; set; }
        [Required]
        [Column("group")]
        public int Group { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [Column("study_program")]
        public DateTime RegistrationDate { get; set; }
    }
}
