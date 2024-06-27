using Epic2_2.Models;

namespace Epic2_2.Data
{
    public class DataSource
    {
        public static IEnumerable<Game> Games { get; set; } = new List<Game>()
        {
            new ()
            {
                Id = 744401,
                Name = "Counter-Strike 2",
                Price = 549,
                Category = "Multiplayer FPS",
                Genres = new List<Genre>()
                {
                    new () {Name = "Tactical", Description = "Think tactical."},
                    new () {Name = "Action", Description = "Action game."}
                }

            },

            new()
            {
                Id = 82933,
                Name = "Banana",
                Price = 0,
                Category = "Clicker",
                Genres = new List<Genre>()
                {
                    new () {Name = "Horror", Description = "Scary game."},
                    new () {Name = "Psycological horror", Description = "Psyco-scary game."}
                }
            },

            new ()
            {
                Id = 228228,
                Name = "Dota 2",
                Price = 0,
                Category = "MOBA",
                Genres = new List<Genre>()
                {
                    new () {Name = "Action", Description = "Action game."},
                    new () {Name = "Strategy", Description = "Strategy game."}
                }
            },

            new()
            {
                Id = 123,
                Name = "PUBG: BATTLEGROUNDS",
                Price = 0,
                Category = "Battle Royale",
                Genres = new List<Genre>()
                {
                    new () {Name = "Action", Description = "Action game."},
                    new () {Name = "Survival", Description = "Try survive but finger."}
                }
            },

            new()
            {
                Id = 124,
                Name = "ELDEN RING",
                Price = 1799,
                Category = "Souls-like",
                Genres = new List<Genre>()
                {
                    new () {Name = "Dark Fantasy", Description = "Dark fantasy world."},
                    new () {Name = "Action", Description = "Action game."},
                    new () {Name = "Role play", Description = "Play your own character."}
                }
            },

             new()
            {
                Id = 8,
                Name = "NARAKA: BLADEPOINT",
                Price = 0,
                Category = "Battle Royale",
                Genres = new List<Genre>()
                {
                    new () {Name = "Action", Description = "Action game."},
                    new () {Name = "Adventure", Description = "Get in adventure."}
                }
            },

              new()
            {
                Id = 12,
                Name = "Apex Legends",
                Price = 0,
                Category = "Battle Royale",
                Genres = new List<Genre>()
                {
                    new () {Name = "Action", Description = "Action game."},
                    new () {Name = "Adventure", Description = "Get in adventure."}
                }
            },

               new()
            {
                Id = 228,
                Name = "Grand Theft Auto V",
                Price = 629,
                Category = "Open World",
                Genres = new List<Genre>()
                {
                    new () {Name = "Action", Description = "Action game."},
                    new () {Name = "Third Person Shooter", Description = "Shoot your enemies."}
                }
            },

                new()
            {
                Id = 987,
                Name = "The Binding of Isaac: Rebirth",
                Price = 229,
                Category = "Rogue-like",
                Genres = new List<Genre>()
                {
                    new () {Name = "Action", Description = "Action game."},
                }
            },

                 new()
            {
                Id = 111112,
                Name = "Sid Meier’s Civilization® VI",
                Price = 525,
                Category = "Souls-like",
                Genres = new List<Genre>()
                {
                    new () {Name = "Strategy", Description = "Strategy game." },
                    new () {Name = "Historical", Description = "Historical game."}
                }
            },

        };
    }
}
