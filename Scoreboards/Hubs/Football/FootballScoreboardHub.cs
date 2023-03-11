using Microsoft.AspNetCore.SignalR;
using Scoreboards.Data.Football;
using Scoreboards.Models.Football;

namespace Scoreboards.Hubs.Football
{
    public class FootballScoreboardHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ConnectedUser", Context.ConnectionId);
        }
        public async Task SendMessage(KeyValuePair<string,FootballScoreboardViewModel> item)
        {
            await Clients.All.SendAsync(
                "UpdateData",
                new KeyValuePair<string,FootballScoreboardViewModel>(item.Key,item.Value)

                );
        }

        public async Task EmitEvent(FootballEventsEnum eventType) {
            await Clients.All.SendAsync("EmittedEvent",eventType);
        }
    }
}
