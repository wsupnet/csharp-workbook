using System;

namespace _03Week
{

    class Program
    {
        static void Main(string[] args)
        {

            RockPaperScissors rockgame = new RockPaperScissors();
            rockgame.Run();

            // Land land = new Land();
            // Console.WriteLine("How many houses do you want?");
            // land.house = Convert.ToInt32(Console.ReadLine());
            // int countHouses = 1;

            // Console.WriteLine("Do want a basketball court or a pool?");
            // land.activity = Console.ReadLine();
            // if (land.activity == "pool"){
            //     Console.WriteLine("Your property will have a pool");
            // } else if (land.activity == "basketball court") {
            //     Console.WriteLine("Your property will have a basketball court");
            // } else {
            //     Console.WriteLine("I'm sorry, {0} isn't available", land.activity);
            // }

            // while (countHouses <= land.house)
            // {

            //     House house = new House();

            //     //Ask how many floors the house will have 
            //     Console.WriteLine("How many floors do you want?");
            //     house.floors = Convert.ToInt32(Console.ReadLine());
            //     int countFloors = 1;



            //     while (countFloors <= house.floors)
            //     {

            //         Console.WriteLine("How many rooms do you want on floor number {0}?", countFloors);
            //         house.rooms = Convert.ToInt32(Console.ReadLine());

            //         //We have to count how many rooms the house wiil have  
            //         int countRooms = 1;
            //         while (countRooms <= house.rooms)
            //         {

            //             Room room = new Room();
            //             Console.WriteLine("What color walls do you want your room to have?", countRooms);
            //             room.color = Console.ReadLine();

            //             string colorResponse = string.Format("Your room's walls will be {0}", room.color);
            //             Console.WriteLine(colorResponse);

            //             Console.WriteLine("What type of floor do you want your room to be?");
            //             room.floorType = Console.ReadLine();
            //             string floorTypeResponse = string.Format("Your floor type will be {0}", room.floorType);
            //             Console.WriteLine(floorTypeResponse);

            //             Console.WriteLine("How many windows do you want in your room?");
            //             room.window = Convert.ToInt32(Console.ReadLine());
            //             string windowResponse = string.Format("You room will have {0} windows", room.window);
            //             Console.WriteLine(windowResponse);


            //             countRooms++;
            //         }
            //         countFloors++;

            //     }
            //     countHouses++;
            }
        }
    }
