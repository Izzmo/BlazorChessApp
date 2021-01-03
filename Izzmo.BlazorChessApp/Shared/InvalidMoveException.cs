using System;

namespace Izzmo.BlazorChessApp.Shared
{
	public class InvalidMoveException : Exception
	{
		public InvalidMoveException(Piece piece, Position from, Position to)
			: base(GetMessage(piece, from, to))
		{
		}

		private static string GetMessage(Piece piece, Position from, Position to)
			=> $"Cannot move {piece.Type} from {from} to {to}.";
	}
}
