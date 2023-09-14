namespace Blazor_routes.Models
{
    public class MovieDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string Category { get; set; } = string.Empty;
        public int Rating { get; set; }
        public string Poster { get; set; } = string.Empty;
    }
}
