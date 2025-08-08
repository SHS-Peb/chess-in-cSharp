using System;

class Program
{
    static void Main(string[] args)
    {
        Piece[,] board = new Piece[8, 8];

        // Place black pawns
        for (int col = 0; col < 8; col++)
        {
            board[1, col] = new Pawn(PieceColor.Black);
        }

        // Place white pawns
        for (int col = 0; col < 8; col++)
        {
            board[6, col] = new Pawn(PieceColor.White);
        }

        // Place black rooks
        board[0, 0] = new Rook(PieceColor.Black);
        board[0, 7] = new Rook(PieceColor.Black);

        // Place white rooks
        board[7, 0] = new Rook(PieceColor.White);
        board[7, 7] = new Rook(PieceColor.White);

        // Print the board
        for (int row = 0; row < 8; row++)
        {
            for (int col = 0; col < 8; col++)
            {
                if (board[row, col] == null)
                    Console.Write(". ");
                else
                    Console.Write(board[row, col].GetSymbol() + " ");
            }
            Console.WriteLine();
        }
    }
}
