using Microsoft.AspNetCore.SignalR;
using Scoreboards.Data.Football;

namespace Scoreboards.Features.Football
{
    public class FootballScoreboardHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ConnectedUser", Context.ConnectionId);
        }
        public async Task SendMessage(KeyValuePair<string, FootballScoreboardViewModel> item)
        {
            await Clients.All.SendAsync(
                "UpdateData",
                new KeyValuePair<string, FootballScoreboardViewModel>(item.Key, item.Value)

                );
        }

        public async Task EmitEvent(KeyValuePair<string, FootballEventsEnum> item, List<string> data)
        {
            if(data == null)
            {
                data = new List<string>();
            }
            await Clients.All.SendAsync(
                "EmittedEvent",
                new KeyValuePair<string, FootballEventsEnum>(item.Key, item.Value),
                data
             );
        }
    }
}
