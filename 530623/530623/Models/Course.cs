using System.ComponentModel.DataAnnotations;

namespace _530623.Models
{
    public class Course
    {
        [Required (ErrorMessage = "Course Id required.")]
        public int? CourseId { get; set; }

        [Required (ErrorMessage = "Course Name is required.")]
        [StringLength(70,ErrorMessage = "Maximum 70 characters allowed")]
        public string CourseName { get; set; }

        [Required (ErrorMessage = "Credit is required.")]
        [Range(1,4, ErrorMessage = "Credit value must be between 1 and 4")]
        public int? Credit { get; set; }

        [Required(ErrorMessage = "Course Fee is required.")]
        public int? CourseFee { get; set; }

        [Required(ErrorMessage = "Course code is required.")]
        public int? CourseCode { get; set; }
    }
}
