using Prog_P2;
namespace Prog_P2.Models
{
    public class Document
    {
        public int DocumentID { get; set; } // Primary Key
        public int ClaimID { get; set; } // Foreign Key to Claim
        public string FilePath { get; set; } = string.Empty; // Default value
    }
}

