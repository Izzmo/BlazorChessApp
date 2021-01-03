using Izzmo.BlazorChessApp.Shared;
using System.Collections.Generic;
using Xunit;

namespace Izzmo.BlazorChessApp.Tests
{
	public class PiecePositionerRookTest
	{
		[Fact]
		public void GivenPawnA3RookA1_ShouldShowRookPositionsA2()
		{
			BoardState boardState = new();
			List<Position> expectedPositions = new()
			{
				new Position('a', 2),
			};

			boardState.Move(new('a', 2), new('a', 3));
			var rookPositions = PiecePositioner.GetPieceMovePositions(boardState, new('a', 1));

			Assert.Single(rookPositions);
			Assert.Equal(expectedPositions, rookPositions);
		}

		[Fact]
		public void GivenPawnA3RookA2_ShouldShowRookPositionsBH2()
		{
			BoardState boardState = new();
			List<Position> expectedPositions = new()
			{
				new Position('a', 2),
				new Position('a', 1),
				new Position('b', 3),
				new Position('c', 3),
				new Position('d', 3),
				new Position('e', 3),
				new Position('f', 3),
				new Position('g', 3),
				new Position('h', 3),
			};

			boardState.Move(new('a', 2), new('a', 4));
			boardState.Move(new('a', 1), new('a', 3));
			var rookPositions = PiecePositioner.GetPieceMovePositions(boardState, new('a', 3));

			Assert.Equal(expectedPositions, rookPositions);
		}
	}
}
