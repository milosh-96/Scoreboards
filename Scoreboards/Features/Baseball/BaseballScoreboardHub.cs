using Microsoft.AspNetCore.SignalR;
using Scoreboards.Data.Football;
using Scoreboards.Features.Baseball;
using Scoreboards.Features.Football;

namespace Scoreboards.Features.Baseball
{
    public class BaseballScoreboardHub : Hub
    {
        public override async Task OnConnectedAsync()
        {
            await Clients.Client(Context.ConnectionId).SendAsync("ConnectedUser", Context.ConnectionId);
        }
        public async Task SendMessage(KeyValuePair<string,BaseballScoreboardViewModel> item)
        {
            await Clients.All.SendAsync(
                "UpdateData",
                new KeyValuePair<string,BaseballScoreboardViewModel>(item.Key,item.Value)

                );
        }

        //public async Task EmitEvent(KeyValuePair<string,FootballEventsEnum> item) {
        //    await Clients.All.SendAsync(
        //        "EmittedEvent",
        //        new KeyValuePair<string,FootballEventsEnum>(item.Key,item.Value)
        //     );
        //}
    }
}
