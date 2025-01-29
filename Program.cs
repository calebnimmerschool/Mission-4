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


namespace Mission_4
{
    class Program
    {
        static void Main()
        {
            // Welcome the user
            Console.WriteLine("Welcome to the Tic Tac Toe Game!");
            Console.WriteLine("Player 1 is X and Player 2 is O.");
            Console.WriteLine("Please select a position (1-9) to place your mark.");

            // Create the game board array
            char[,] gameBoard = new char[3, 3]; // Initialize with empty values (default is '\0')

            // Create Board object
            Board board = new Board(gameBoard);

            // Game loop
            int turn = 0; // Player 1 starts (X)
            string winner = "No winner yet."; // Initialize winner check
            while (winner == "No winner yet.")
            {
                board.printBoard();

                // Ask the current player for their move
                Console.WriteLine($"Player {(turn % 2 == 0 ? 1 : 2)}'s turn (Mark: {(turn % 2 == 0 ? 'X' : 'O')})");
                int move = GetPlayerMove();
                
                // Map the player's choice to board position
                if (gameBoard[(move - 1) / 3, (move - 1) % 3] == '\0')  // Check if cell is empty
                {
                    gameBoard[(move - 1) / 3, (move - 1) % 3] = turn % 2 == 0 ? 'X' : 'O';
                    turn++; // Switch to the next player's turn
                }
                else
                {
                    Console.WriteLine("That position is already taken. Try again.");
                    continue;
                }

                // Check for winner only after making a move
                winner = board.checkWinner(gameBoard);
                if (winner != "No winner yet.")
                {
                    board.printBoard();
                    Console.WriteLine(winner);
                }
            }

            Console.WriteLine("Game Over!");
        }

        // Get and validate the player's move
        static int GetPlayerMove()
        {
            int move = 0;
            while (true)
            {
                Console.Write("Enter a position (1-9): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out move) && move >= 1 && move <= 9)
                {
                    return move;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 9.");
                }
            }
        }
    }
}
