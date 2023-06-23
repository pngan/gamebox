namespace gamebox.Server.HubHelpers
{
    public class GameRepository : IGameRepository
    {
        // TODO replace this in memory store with Redis with a TTL
        private readonly Dictionary<string, string> _gameInformation = new();

        public bool DoesGameExist(string gameCode) => _gameInformation.ContainsKey(gameCode);

        public string GetGameInfo(string gameCode)
            => _gameInformation.TryGetValue(gameCode, out var gameInfo) ? gameInfo : String.Empty;

        public void AddorUpdateGameInfo(string gameCode, string gameInfo)
            => _gameInformation[gameCode] = gameInfo;
    }
}