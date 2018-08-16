﻿using System;

namespace Alice
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompt the user for input
            string aliceString = "Alice was beginning to get very tired of sitting by her sister on the bank," +
                " and of having nothing to do: once or twice she had peeped into the book her sister was reading," +
                " but it had no pictures or conversations in it, ‘and what is the use of a book,’" +
                " thought Alice ‘without pictures or conversation?’";
            Console.WriteLine(aliceString);

            //initialize and set a placeholder value to termFound
            //we'll use this in the next few lines... 
            //... to tell the program whether or not the search term was found.
            bool termFound = false;

            //acquire search term from user
            Console.WriteLine("Type a term to search for in the passage:");
            string searchTerm = Console.ReadLine();

            //use the FindTerm method to tell the program whether or not the search term was found.
            termFound = FindTerm(searchTerm, termFound, aliceString);

            //execute until the user presses ENTER without entering a term to search...
            //... or closes the program.
            //we do this to continue executing the if/else-if statement...
            //... so that the user can search for 2+ terms without having to reopen the program.
            while (searchTerm != "")
            {
                //execute if the user input was found within aliceString
                if (termFound == true)
                {
                    //tell the user that their search term was found in the passage
                    Console.WriteLine("Term \"" + searchTerm + "\" was found.");

                    //allow the user to search again
                    Console.WriteLine("Type a term to search for in the passage:");
                    searchTerm = Console.ReadLine();

                    //search for the term and update the value of termFound.
                    //this will adjust the outcome of the if/else-if "loop."
                    termFound = FindTerm(searchTerm, termFound, aliceString);
                }
                //execute if the user input was not found within aliceString
                else if (termFound == false)
                {
                    //tell the user that their search term was not found in the passage
                    Console.WriteLine("Term \"" + searchTerm + "\" was not found.");

                    //allow the user to search again
                    Console.WriteLine("Type a term to search for in the passage:");
                    searchTerm = Console.ReadLine();

                    //search for the term and update the value of termFound.
                    //this will adjust the outcome of the if/else-if "loop."
                    termFound = FindTerm(searchTerm, termFound, aliceString);
                }
            }

        }

        private static bool FindTerm(string searchTerm, bool termFound, string aliceString)
        {
            //determine whether the search query is contained within aliceString.
            //achieve case-insensitivity by turning user input to ALLCAPS and aliceString to ALLCAPS...
            //... before doing the comparison.
            termFound = aliceString.ToUpper().Contains(searchTerm.ToUpper());

            return termFound;
        }

    }
}
