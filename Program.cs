using System;

class Program
{
    static void Main(string[] args)
{
    string[,] board = new string[8, 8];

    // Set up black pieces
    board[0, 0] = "♜"; board[0, 1] = "♞"; board[0, 2] = "♝"; board[0, 3] = "♛";
    board[0, 4] = "♚"; board[0, 5] = "♝"; board[0, 6] = "♞"; board[0, 7] = "♜";
    for (int col = 0; col < 8; col++) board[1, col] = "♟";

    // Set up empty spaces
    for (int row = 2; row <= 5; row++)
        for (int col = 0; col < 8; col++)
            board[row, col] = " . ";

    // Set up white pieces
    for (int col = 0; col < 8; col++) board[6, col] = "♙";
    board[7, 0] = "♖"; board[7, 1] = "♘"; board[7, 2] = "♗"; board[7, 3] = "♕";
    board[7, 4] = "♔"; board[7, 5] = "♗"; board[7, 6] = "♘"; board[7, 7] = "♖";

    // Print the board to the console
    for (int row = 0; row < 8; row++)
    {
        for (int col = 0; col < 8; col++)
        {
            Console.Write(board[row, col] + " ");
        }
        Console.WriteLine();
    }
}

}

