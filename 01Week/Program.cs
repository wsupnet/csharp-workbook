using System;

namespace _01Week
{
    class Program
    {
        static void Main(string[] args)
        {

            // Declare out datatypes 
            // int number1 = 0;
            // int number2 = 0;

            //Ask user for the initial values 
            //first value 
            // Console.WriteLine("Please enter the first value");
            // number1 = Convert.ToInt32(Console.ReadLine());

            // second value 
            // Console.WriteLine("Please enter the second value");
            // number2 = Convert.ToInt32(Console.ReadLine());


            // // Calling Add function 
            // Console.WriteLine(Add(number1, number2));

            // // Calling the EnterName function 
            // EnterName();
            // Console.WriteLine(ConvertYardsToInches(number1));

            string strFirstName, strLastName, strFavoriteTeam, strEthnicity;

            Console.WriteLine("Enter first name: ");
            strFirstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            strLastName = Console.ReadLine();

            Console.WriteLine("Enter favorite sports team: ");
            strFavoriteTeam = Console.ReadLine();

            Console.WriteLine("Enter ethnicity: ");
            strEthnicity = Console.ReadLine();

            Console.WriteLine(DatingProfile(strFirstName, strLastName, strFavoriteTeam, strEthnicity));

        }

        public static string DatingProfile(string strFirstName, string strLastName, string strFavoriteTeam, string strEthnicity)
        {

            return string.Format("{0} likes to hike in the outdoors. Her favorite team is the {1}. She's {2}", strFirstName, strFavoriteTeam, strEthnicity); 
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
