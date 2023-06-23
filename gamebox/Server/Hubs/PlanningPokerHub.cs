using gamebox.Server.HubHelpers;
using Microsoft.AspNetCore.SignalR;

namespace gamebox.Server.Hubs;

public class GameHub : Hub
{
    public async Task BroadcastGameInfo(string gameCode, string userName)
    {
        await Clients.Group(gameCode).SendAsync("ReceiveGameInfo", gameCode, userName);
    }

    public async Task StartGame(string gameCode)
    {
        await Clients.Group(gameCode).SendAsync("StartGame", gameCode);
    }

    public async Task JoinGame(string gameCode, string userName)
    {
        await Groups.AddToGroupAsync(Context.ConnectionId, gameCode);
    }

    // Don't use this method, because it sends to all clients. Exists as example only. Won't be scalable in real life.
    public async Task SendMessage(string user, string message)
    {
        await Clients.All.SendAsync("ReceiveMessage", user, message);
    }
}
