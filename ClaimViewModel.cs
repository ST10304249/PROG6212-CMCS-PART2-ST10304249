using Prog_P2;
using Microsoft.AspNetCore.Mvc;

namespace Prog_P2.Models
{
    public class ClaimViewModel
    {
        public DateTime ClaimPeriod { get; set; }
        public int HoursWorked { get; set; }
        public decimal HourlyRate { get; set; }
        public IFormFile? Document { get; set; }  // File upload
        public string? AdditionalNotes { get; set; }  // Any extra notes
    }
}

