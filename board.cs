namespace Mission_4;

public class board
{
    int userInput;
    string usedPositions = "";

    private int[,] ticTacBoard;

    public board(int[,] boardArray)
    {
        ticTacBoard = boardArray;
    }

    public void printBoard()
    {
        for (int i = 0; i < ticTacBoard.GetLength(0); i++)
        {
            for (int j = 0; j < ticTacBoard.GetLength(1); j++)
            {
                Console.Write(ticTacBoard[i, j] + " ");
            }
            Console.WriteLine();
        }

    }

    public void detectWinner()
    {

    }
}