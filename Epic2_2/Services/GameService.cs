using Epic2_2.Models;

namespace Epic2_2.Services
{
    public class GameService
    {
        public Game GetGameByID(IEnumerable<Game> games, int id)
        {
            return games.FirstOrDefault(x => x.Id == id);
        }
        public List<Game> GetGamesInPriceRange(IEnumerable<Game> games, int startRange, int endRange)
        {
            return games.Where(x => x.Price >= startRange && x.Price <= endRange).ToList();
        }
        public List<Genre> GetGenresOfGame(IEnumerable<Game> games, int id)
        {
            return games.FirstOrDefault(x => x.Id == id).Genres.ToList();
        }
        public List<string> GetUniqueGameCategories(IEnumerable<Game> games)
        {
            return games.Select(x => x.Category).Distinct().ToList();
        }
        public IEnumerable<Game> FilterGames(IEnumerable<Game> games, string category, List<string> genres)
        {
            return games.Where(x => x.Category == category && x.Genres.Any(y => genres.Contains(y.Name)));
        }
        public IEnumerable<Game> PaginationGames(IEnumerable<Game> games, int page, int paginationSize)
        {
            return games.Skip(page * paginationSize).Take(paginationSize);
        }
    }
}
