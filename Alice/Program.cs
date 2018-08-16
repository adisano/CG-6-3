using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            string aliceString = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it, ‘and what is the use of a book,’" +
                " thought Alice ‘without pictures or conversation?’";
            Console.WriteLine(aliceString);
            Console.WriteLine("Type a term to search for in the above passage:");

            string searchTerm = Console.ReadLine();

            bool termFound = aliceString.ToUpper().Contains(searchTerm.ToUpper());

            if (termFound == true)
            {
                Console.WriteLine("Term \"" + searchTerm + "\" was found.");
            }
            else if (termFound == false)
            {
                Console.WriteLine("Term \"" + searchTerm + "\" was not found.");
            }

            Console.ReadLine();
        }
    }
}
