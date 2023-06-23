namespace gamebox.Server.HubHelpers
{
    public interface IGameRepository
    {
        bool DoesGameExist(string gameCode);
        string? GetGameInfo(string gameCode);
        void AddorUpdateGameInfo(string gameCode, string gameInfo);
    }
}
