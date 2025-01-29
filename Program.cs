// The “Driver” class (the Program.cs class with the main method where the program begins)
// will:

//     • Create a game board array to store the players’ choices
//     • Ask each player in turn for their choice and update the game board array
//     • Print the board by calling the method in the supporting class
//     • Check for a winner by calling the method in the supporting class, and notify the players
// when a win has occurred and which player won the game

// board b = new board();
// string position = "";
using System;

namespace Mission4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to our Tic Tac Toe Game!");
            char[,] gameBoard = {
                {'1', '2', '3'},
                {'4', '5', '6'},
                {'7', '8', '9'}
            };

            // Print the game board
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Welcome message
            
            Console.Write("Please select a position 1-9 to place your 'X': ");
            Console.ReadLine();
        }
    }
}
