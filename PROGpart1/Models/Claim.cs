namespace PROGpart1.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string LecturerName { get; set; }
        public DateTime SubmissionDate { get; set; }
        public string Status { get; set; } // e.g., "Pending", "Approved", "Rejected"
        public string SupportDocuments { get; set; } // Path to uploaded documents
        public string Details { get; set; }
    }
}