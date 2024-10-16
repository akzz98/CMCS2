namespace CMCS2.Models
{
    public class Claim
    {
        public int ClaimId { get; set; }
        public double HoursWorked { get; set; }
        public double HourlyRate { get; set; }
        public string Notes { get; set; }
        public string DocumentPath { get; set; } 
        public string Status { get; set; } = "Pending";
        public DateTime DateSubmitted { get; set; } = DateTime.Now;
        public string LecturerId { get; set; }


    }
}
