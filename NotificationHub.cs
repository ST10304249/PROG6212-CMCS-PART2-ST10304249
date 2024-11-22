using Microsoft.AspNetCore.SignalR;
using Prog_P2;

namespace Prog_P2.Hubs
{
    public class NotificationHub : Hub
    {
        // This method can be called by clients to send a message to all connected clients
        public async Task SendClaimUpdate(int claimId, string status, string notes)
        {
            await Clients.All.SendAsync("ReceiveClaimUpdate", claimId, status, notes);
        }
    }
}

