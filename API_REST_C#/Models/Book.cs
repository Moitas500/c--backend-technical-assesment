namespace API_REST_C_.Models
{
    public class Book
    {

        public int Id { get; set; }

        public required string Name { get; set; }

        public int Date { get; set; }

        public required Person Author { get; set; }

        public required Genre genre { get; set; }

    }
}
