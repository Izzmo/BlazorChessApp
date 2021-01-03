using Izzmo.BlazorChessApp.Shared;
using Xunit;

namespace Izzmo.BlazorChessApp.Tests
{
	public class PiecePositionerInitialTest
	{
		[Fact]
		public void GivenWhitePawnStartingPosition_ShouldShowPositionsA3A4()
		{
			BoardState boardState = new();
			Position piecePosition = new('a', 2);
			Position expectedPosition1 = new('a', 3);
			Position expectedPosition2 = new('a', 4);

			var positions = PiecePositioner.GetPieceMovePositions(boardState, piecePosition);

			Assert.Equal(expectedPosition1, positions[0]);
			Assert.Equal(expectedPosition2, positions[1]);
		}

		[Fact]
		public void GivenBlackPawnStartingPosition_ShouldShowPositionsA6A5()
		{
			BoardState boardState = new();
			Position piecePosition = new('a', 7);
			Position expectedPosition1 = new('a', 6);
			Position expectedPosition2 = new('a', 5);

			var positions = PiecePositioner.GetPieceMovePositions(boardState, piecePosition);

			Assert.Equal(expectedPosition1, positions[0]);
			Assert.Equal(expectedPosition2, positions[1]);
		}

		[Fact]
		public void GivenWhiteRookStartingPosition_ShouldShowNoPositions()
		{
			BoardState boardState = new();
			Position piecePosition = new('a', 1);

			var positions = PiecePositioner.GetPieceMovePositions(boardState, piecePosition);

			Assert.Empty(positions);
		}

		[Fact]
		public void GivenBlackRookStartingPosition_ShouldShowNoPositions()
		{
			BoardState boardState = new();
			Position piecePosition = new('a', 8);

			var positions = PiecePositioner.GetPieceMovePositions(boardState, piecePosition);

			Assert.Empty(positions);
		}

		[Fact]
		public void GivenNoPiecePosition_ShouldShowNoPositions()
		{
			BoardState boardState = new();
			Position piecePosition = new('a', 3);

			var positions = PiecePositioner.GetPieceMovePositions(boardState, piecePosition);

			Assert.Empty(positions);
		}
	}
}
