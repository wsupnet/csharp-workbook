using System;
using System.Text;

namespace ConsoleApplication
{

    // enum FavoriteSportsTeam
    // {
    //     Spurs,
    //     Rockets,
    //     Lakers
    // }


    class Program
    {
        static void Main(string[] args)
        {

            //We have created a new person
            Person person = new Person();

            //Add the values of the properties that define that new person 
            Console.WriteLine("Enter your first name");
            person.firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            person.lastName = Console.ReadLine();

            Console.WriteLine("Enter your favorite sports team");
            person.favoriteTeam = Console.ReadLine();

            Console.WriteLine("Enter your ethnicity");
            person.ethnicity = Console.ReadLine();

            Console.WriteLine("Enter your gender");
            person.gender = Console.ReadLine();


            Console.WriteLine(DatingProfile(person));

        }
        public static string DatingProfile(Person person)
        {
            StringBuilder strDescription = new StringBuilder("{0} likes to hike in the outdoors. Favorite team is the {1}. Ethnicity is {2}. ");
            // string strDescription = "{0} likes to hike in the outdoors. Favorite team is the {1}. Ethnicity is {2}. ";

            if (person.favoriteTeam == "spurs")
            {
                strDescription.Append("GO SPURS GO");
                // strDescription += "GO SPURS GO!";
            }
            else
            {
                strDescription.Append("Rockets Rock");
                // strDescription += "ROCKETS ROCK!";
            }

            return string.Format(strDescription.ToString(), person.firstName, person.favoriteTeam, person.ethnicity);
        }


        public static int Add(int number1, int number2)
        {
            //Begin the add process 
            return number1 + number2;
            // total = number1 + number2; 
            // Console.WriteLine("Your total is: " + total);

        }

        public static double ConvertYardsToInches(int number1)
        {
            return number1 * 36.000;
        }

        public static void EnterName()
        {
            // Declare your variables 
            string strUserInput = "";

            //Ask the user if their name is correct
            Console.WriteLine("Hello John, Please type a new name.");
            strUserInput = Console.ReadLine();

            //Output value to terminal 
            Console.WriteLine("Hello, " + strUserInput);
        }
    }
}
