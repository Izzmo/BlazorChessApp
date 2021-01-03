namespace Izzmo.BlazorChessApp.Shared
{
	public class Piece
	{
		public Piece(PieceType type, PieceColor color)
		{
			Type = type;
			Color = color;
		}

		public bool InStartingPosition { get; set; } = true;
		
		public PieceType Type { get; }
		public PieceColor Color { get; }
	}
}
