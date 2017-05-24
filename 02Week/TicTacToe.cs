using System;

namespace ConsoleApplication
{
    public class TicTacToe
    {
        public static string playerTurn = "X";
        public static string[][] board = new string[][]
        {
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "},
        new string[] {" ", " ", " "}
         };

        public void Run()
        {
            while (!CheckForWin())
            {
                playerTurn = playerTurn == "X" ? "0" : "X";
                DrawBoard();
                GetInput();
            }

            DrawBoard();
            Console.WriteLine(string.Format("Congrats player {0}. You have won!", playerTurn));
        }

        public static void GetInput()
        {

            //We are asking the user for data through prompts 
            Console.WriteLine("Player " + playerTurn);
            Console.WriteLine("Enter Row:");
            int row = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Column:");
            int column = Int32.Parse(Console.ReadLine());

            //Doing something with user data 
            if(PlaceMark(row, column)){
                return;
            } else {
                Console.WriteLine("A mark already exists in that spot");
                GetInput();
            }
        }

        public static bool PlaceMark(int row, int column)
        {
            //What variable holds the x
            //playerTurn
            var mark = board[row][column];
            if (string.IsNullOrEmpty(board[row][column]) || board[row][column] == " ")
            {
                board[row][column] = playerTurn;
                return true;
            } else {
                return false;
            }
        }

        public static bool CheckForWin()
        {
            return HorizontalWin() || VerticalWin() || DiagonalWin();
        }

        public static bool HorizontalWin()
        {

            return (board[0][0] == playerTurn && board[0][1] == playerTurn && board[0][2] == playerTurn ||
            board[1][0] == playerTurn && board[1][1] == playerTurn && board[1][2] == playerTurn ||
            board[2][0] == playerTurn && board[2][1] == playerTurn && board[2][2] == playerTurn);
        }

        public static bool VerticalWin()
        {
            return (board[0][0] == playerTurn && board[1][0] == playerTurn && board[2][0] == playerTurn ||
            board[0][1] == playerTurn && board[1][1] == playerTurn && board[2][1] == playerTurn ||
            board[0][2] == playerTurn && board[1][2] == playerTurn && board[2][2] == playerTurn);
        }

        public static bool DiagonalWin()
        {
            return (board[0][0] == playerTurn && board[1][1] == playerTurn && board[2][2] == playerTurn ||
            board[0][2] == playerTurn && board[1][1] == playerTurn && board[2][0] == playerTurn);
        }

        public static void DrawBoard()
        {
            var boardInfo = String.Join("|", board[0]);

            Console.WriteLine("  0 1 2");
            Console.WriteLine("0 " + String.Join("|", board[0]));
            Console.WriteLine("  -----");
            Console.WriteLine("1 " + String.Join("|", board[1]));
            Console.WriteLine("  -----");
            Console.WriteLine("2 " + String.Join("|", board[2]));
            return;
        }
    }
}