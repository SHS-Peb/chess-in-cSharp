using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] board = new string[8, 8];

        // Fill the board with empty spaces
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                board[row, col] = " . ";
            }
        }

        // Print the board to the console
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                Console.Write(board[row, col]);
            }
            Console.WriteLine(); // Newline after each row
        }
    }
}

