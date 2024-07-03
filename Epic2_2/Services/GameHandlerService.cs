using Epic2_2.Models;

namespace Epic2_2.Services
{
    public class GameHandlerService : GameService
    {
        public void DrawStartMenu()
        {
            Console.WriteLine("1. Get one Game by Id");
            Console.WriteLine("2. Get a list of Games in price range");
            Console.WriteLine("3. Get a list of Genres by a game");
            Console.WriteLine("4. Get unique Categories from game list");
            Console.WriteLine("5. Filter games by Category and Genres");
            Console.WriteLine("6. Show all games");
            Console.WriteLine("0. Shut down program");
            Console.WriteLine("\nChoose an option to continue: ");
        }
        private void DisplayFirstMethod(IEnumerable<Game> games, int id)
        {
            var game = GetGameByID(games, id);
            Console.WriteLine($"Game name: {game.Name}");
            Console.WriteLine($"Price: {game.Price} UAH");
            Console.WriteLine($"Category: {game.Category}");
        }
        private void DisplaySecondMethod(IEnumerable<Game> data, int startRange, int endRange)
        {
            var games = GetGamesInPriceRange(data, startRange, endRange);
            foreach (var game in games)
            {
                Console.WriteLine($"Game name: {game.Name}",
                                  $"Price: {game.Price} UAH",
                                  $"Category: {game.Category}");
            }
        }
        private void DisplayThirdMethod(IEnumerable<Game> games, int id)
        {
            foreach (var genre in GetGenresOfGame(games, id))
            {
                Console.WriteLine(genre.Name);
            }
        }
        private void DisplayFourthMethod(IEnumerable<Game> data)
        {
            foreach (var category in GetUniqueGameCategories(data))
            {
                Console.WriteLine(category);
            }
        }
        private void DisplayFifthMethod(IEnumerable<Game> data, string category, List<string> genres)
        {
            foreach (var game in FilterGames(data, category, genres))
            {
                Console.WriteLine($"Game name: {game.Name}",
                                  $"Price: {game.Price} UAH",
                                  $"Category: {game.Category}");
            }
        }
        private void DisplaySixthMethod(IEnumerable<Game> data)
        {
            var paginationSize = 5;
            var pages = data.Count() / paginationSize;
            for (int i = 0; i <= pages;)
            {
                Console.Clear();
                var pageData = PaginationGames(data, i, paginationSize);
                Console.WriteLine($"PAGE {i + 1}");
                foreach (var page in pageData)
                {
                    Console.WriteLine($"ID{page.Id}\nGAME NAME: {page.Name}");
                }
                Console.WriteLine("press q - open the previuos page e to open next one page, enter to choose the game by id...");
                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.E)
                {
                    i += 1;
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    i += -1;
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    DisplayFirstMethod(data, SelectGame());
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Uknown command. Returning to the first page...");
                    i = 0;
                }
            }
        }
        private int SelectGame()
        {
            Console.WriteLine("Enter id of the game: ");
            var userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }
        private void ChooseOption(IEnumerable<Game> data, int option)
        {
            switch (Convert.ToInt32(option))
            {
                case 1:
                    DisplayFirstMethod(data, SelectGame());
                    break;
                case 2:
                    Console.WriteLine("Enter low range:");
                    int startRange = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter high range: ");
                    int endRange = Convert.ToInt32(Console.ReadLine());
                    DisplaySecondMethod(data, startRange, endRange);
                    break;
                case 3:
                    DisplayThirdMethod(data, SelectGame());
                    break;
                case 4:
                    DisplayFourthMethod(data);
                    break;
                case 5:
                    Console.WriteLine("Enter category: ");
                    var category = Console.ReadLine();
                    Console.WriteLine("Enter genres(Action,Dark Fantasy): ");
                    DisplayFifthMethod(data, category, new List<string>(Console.ReadLine().Split(',')));
                    break;
                case 6:
                    DisplaySixthMethod(data);
                    break;
                default: break;
            }
        }
        public void HandleGameService(IEnumerable<Game> data)
        {
            var userInput = "";
            while (true)
            {
                Console.ReadKey();
                Console.Clear();
                DrawStartMenu();
                userInput = Console.ReadLine();
                if (userInput == "0")
                {
                    break;
                }
                else
                {
                    ChooseOption(data, Convert.ToInt32(userInput));
                }
            }

        }
    }
}
