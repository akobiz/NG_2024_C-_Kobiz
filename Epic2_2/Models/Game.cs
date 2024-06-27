namespace Epic2_2.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Category { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
    }
}
