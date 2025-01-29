public class Board
{
    private char[,] ticTacBoard;
    private string[] positionLabels = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

    //constructor 
    public Board(char[,] boardArray)
    {
        ticTacBoard = boardArray;
    }

    //method to print out board
    public void printBoard()
    {
        int posIndex = 0; 
        for (int i = 0; i < ticTacBoard.GetLength(0); i++) //to get the row
        {
            for (int j = 0; j < ticTacBoard.GetLength(1); j++) //to get the column
            {
                // Print position number if the cell is empty, otherwise print the cell value
                //psuedo code for this line: if empty at this position of the array,
                //print the number, otherwise print what the value is printed
                Console.Write(ticTacBoard[i, j] == '\0' ? positionLabels[posIndex] : ticTacBoard[i, j].ToString());
                
                if (j < 2) Console.Write(" | ");
                posIndex++; //get next number position
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---------");
        }
    }

    public string checkWinner(char[,] tictacBoard)
    {
        // Check rows and columns
        for (int i = 0; i < 3; i++)
        {
            if (ticTacBoard[i, 0] != '\0' && ticTacBoard[i, 0] == ticTacBoard[i, 1] && ticTacBoard[i, 1] == ticTacBoard[i, 2])
                return $"Winner is {ticTacBoard[i, 0]}";
            if (ticTacBoard[0, i] != '\0' && ticTacBoard[0, i] == ticTacBoard[1, i] && ticTacBoard[1, i] == ticTacBoard[2, i])
                return $"Winner is {ticTacBoard[0, i]}";
        }

        // Check diagonals
        if (ticTacBoard[0, 0] != '\0' && ticTacBoard[0, 0] == ticTacBoard[1, 1] && ticTacBoard[1, 1] == ticTacBoard[2, 2])
            return $"Winner is {ticTacBoard[0, 0]}";
        if (ticTacBoard[0, 2] != '\0' && ticTacBoard[0, 2] == ticTacBoard[1, 1] && ticTacBoard[1, 1] == ticTacBoard[2, 0])
            return $"Winner is {ticTacBoard[0, 2]}";

        // Check if there's no winner
        return "No winner yet.";
    }
}
