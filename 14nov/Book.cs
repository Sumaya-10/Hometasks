namespace _14nov
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AuthorName { get; set; }
        public decimal Price { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Author: {AuthorName}, Price: {Price}");
        }
    }
}
