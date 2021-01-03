namespace Izzmo.BlazorChessApp.Shared
{
	/// <summary>
	/// A position coordinate.
	/// </summary>
	public struct Position
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Position"/> stucture.
		/// </summary>
		/// <param name="column">The column.</param>
		/// <param name="row">The row.</param>
		public Position(char column, int row)
		{
			Column = column;
			Row = row;
		}

		public char Column { get; }
		
		public int Row { get; }

		public override string ToString()
		{
			return $"{Column}{Row}";
		}
	}
}
