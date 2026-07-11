using System.ComponentModel.DataAnnotations;
using practice_1.Validation;
namespace practice_1.Models
{
    public class JobApplication
    {
        [Required (ErrorMessage = "Applicant name is required")]
        [StringLength( 70, ErrorMessage = "Maximum 70 character allowed")]
        [NoDigits]
        public string ApplicantName { get; set; }

        [Required (ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email format.")]
        public string Email { get; set; }

        [Required (ErrorMessage = "Position is required.")]
        [StringLength(50,ErrorMessage = "Maximum 50 characters allowed")]
        public string PositonAppliedFor { get; set; }

        [Required(ErrorMessage = "Years of experience is required.")]
        [Range(0,40, ErrorMessage = "Years of experience must be between 0 and 40")]
        public int? YearOfExperience { get; set; }

        [Required (ErrorMessage = "Expected salary is required")]
        [Range(10000,500000, ErrorMessage = "Salary must be between 10000 and 500000")]
        public int? ExpectedSalary { get; set; }
    }
}
