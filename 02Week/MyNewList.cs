using System;
using System.Collections.Generic;

namespace ConsoleApplication
{
    class MyNewList
    {
        public void Run()
        {


            List<string> people = new List<string>();

            Console.WriteLine("Please enter 3 people to join your party");
            while (people.Count < 3)
            {

                var input = Console.ReadLine();

                if (people.Contains(input))
                {
                    Console.WriteLine("That name already exists, please add another name.");
                    Console.WriteLine("Would you like to delete that name?");
                    var response = Console.ReadLine();
                    if (response == "yes") {
                        people.Remove(input);
                        Console.WriteLine("Successfully removed: " + (input) + "." + " Continue adding names");
                    }
                } 
                else 
                {
                    people.Add(input);
                }
            }


            Console.WriteLine("Here are the people in your party");
            people.ForEach(Console.WriteLine);

        }
        /*
           Ask the user the 10 names and add each name
           into a list  */

        //Count 
        //Console.WriteLine
        //List<string> people
        //people.Add()
    }
}