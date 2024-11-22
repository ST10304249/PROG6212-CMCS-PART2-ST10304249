using Prog_P2;
namespace Prog_P2.Models
{
    public enum ClaimStatus
    {
        Pending,    // Default state when the claim is first submitted
        Approved,   // When the claim has been approved by a manager
        Rejected    // When the claim has been rejected
    }
}

