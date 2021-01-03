using System.Collections.Generic;

namespace Izzmo.BlazorChessApp.Shared
{
	public static class PiecePositioner
	{
		public static List<Position> GetPieceMovePositions(BoardState boardState, Position position)
		{
			var possiblePositions = new List<Position>();
			
			Piece piece = boardState.GetSquare(position);

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

			if (piece.Type == PieceType.Rook)
			{
				for (int row = position.Row + 1; row <= 8; row++)
				{
					var newPosition = new Position(position.Column, row);
					try
					{
						boardState.GetSquare(newPosition);
						break;
					}
					catch (KeyNotFoundException)
					{
						possiblePositions.Add(newPosition);
						continue;
					}
				}

				for (int row = position.Row - 1; row > 0; row--)
				{
					var newPosition = new Position(position.Column, row);
					try
					{
						boardState.GetSquare(newPosition);
						break;
					}
					catch (KeyNotFoundException)
					{
						possiblePositions.Add(newPosition);
						continue;
					}
				}

				for (char column = (char)(position.Column + 1); column <= 'h'; column++)
				{
					var newPosition = new Position(column, position.Row);
					try
					{
						boardState.GetSquare(newPosition);
						break;
					}
					catch (KeyNotFoundException)
					{
						possiblePositions.Add(newPosition);
						continue;
					}
				}

				for (char column = (char)(position.Column - 1); column >= 'a'; column--)
				{
					var newPosition = new Position(column, position.Row);
					try
					{
						boardState.GetSquare(newPosition);
						break;
					}
					catch (KeyNotFoundException)
					{
						possiblePositions.Add(newPosition);
						continue;
					}
				}
			}

			return possiblePositions;
		}
	}
}
