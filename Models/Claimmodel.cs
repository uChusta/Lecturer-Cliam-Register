using System.ComponentModel.DataAnnotations;

namespace Lecturer_Claim_Register.Models
{
    public class Claimmodel
    {
        [Key]
        public int ClaimId { get; set; }
        [Required]
        public string LecturerName { get; set; } = "";
        [Required]
        public string ModuleCode { get; set; } = "";
        [Range (1, 30)]
        public double HoursWorked { get; set; }
        
        [Range (0, double.MaxValue)]
        public decimal HourlyRate { get; set; }

        public string ClaimMonth { get; set; } = "";

        public string Status { get; set; } = "Draft";

        public decimal TotalAmount => (Decimal)HoursWorked * HourlyRate;
    }
}
