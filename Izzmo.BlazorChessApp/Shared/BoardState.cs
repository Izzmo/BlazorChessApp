using System.Collections.Generic;

namespace Izzmo.BlazorChessApp.Shared
{
	public class BoardState
	{
		private readonly Dictionary<Position, Piece> state = new Dictionary<Position, Piece>();

		public BoardState()
		{
			state.Add(new Position('a', 1), new Piece(PieceType.Rook, PieceColor.White));
			state.Add(new Position('a', 2), new Piece(PieceType.Pawn, PieceColor.White));
			state.Add(new Position('a', 7), new Piece(PieceType.Pawn, PieceColor.Black));
			state.Add(new Position('a', 8), new Piece(PieceType.Rook, PieceColor.Black));
		}

		public Piece GetSquare(Position position)
		{
			return state[position];
		}
	}
}
