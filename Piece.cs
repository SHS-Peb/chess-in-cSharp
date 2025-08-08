public enum PieceColor
{
    White,
    Black
}

public enum PieceType
{
    Pawn,
    Rook,
    Knight,
    Bishop,
    Queen,
    King
}

public abstract class Piece
{
    public PieceColor Color { get; }
    public PieceType Type { get; }

    protected Piece(PieceColor color, PieceType type)
    {
        Color = color;
        Type = type;
    }

    public abstract string GetSymbol();
}

public class Pawn : Piece
{
    public Pawn(PieceColor color) : base(color, PieceType.Pawn) { }

    public override string GetSymbol()
    {
        return Color == PieceColor.White ? "P" : "p";
    }
}

public class Rook : Piece
{
    public Rook(PieceColor color) : base(color, PieceType.Rook) { }

    public override string GetSymbol()
    {
        return Color == PieceColor.White ? "R" : "r";
    }
}
