using System.Collections.Generic;

namespace Izzmo.BlazorChessApp.Shared
{
	public static class PiecePositioner
	{
		public static List<Position> GetPieceMovePositions(BoardState boardState, Position position)
		{
			var possiblePositions = new List<Position>();
			Piece piece;

			try
			{
				piece = boardState.GetSquare(position);
			}
			catch (KeyNotFoundException)
			{
				return possiblePositions;
			}

			if (piece.Type == PieceType.Pawn)
			{
				int row = position.Row + 1;
				if (piece.Color == PieceColor.Black)
					row -= 2;

				possiblePositions.Add(new Position(position.Column, row));

				if (piece.InStartingPosition)
				{
					row++;
					if (piece.Color == PieceColor.Black)
						row -= 2;

					possiblePositions.Add(new Position(position.Column, row));
				}
			}

			return possiblePositions;
		}
	}
}
