﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;
using Prog_P2;

public class ClaimHub : Hub
{
    public async Task UpdateClaimStatus(int claimId, string status, string note)
    {
        await Clients.All.SendAsync("ReceiveClaimUpdate", claimId, status, note);
    }

    public async Task SendClaimUpdate()
    {
        await Clients.All.SendAsync("RefreshClaims");
    }
}







