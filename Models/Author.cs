namespace Buzea_Ana_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Navigational property
        public ICollection<Book>? Books { get; set; }
    }
}
