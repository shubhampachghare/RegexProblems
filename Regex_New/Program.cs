namespace Regex_New
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patterns patterns = new Patterns();
            Console.WriteLine(patterns.ValidateFName("Shubham"));
            Console.WriteLine(patterns.ValidateFName("Pachghare"));
            Console.WriteLine(patterns.ValidateEmail("shubham.pachghare@gmail.co.in"));

        }
    }
}