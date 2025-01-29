// The “Driver” class (the Program.cs class with the main method where the program begins)
// will:

//     • Create a game board array to store the players’ choices
//     • Ask each player in turn for their choice and update the game board array
//     • Print the board by calling the method in the supporting class
//     • Check for a winner by calling the method in the supporting class, and notify the players
// when a win has occurred and which player won the game

// Welcome the user to the game
Console.WriteLine("Welcome to our Tic Tac Toe Game!");
Console.WriteLine("Please select a position 1-9 to place your 'x'.");

board b = new board();
