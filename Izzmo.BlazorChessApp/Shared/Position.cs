using System;

namespace Izzmo.BlazorChessApp.Shared
{
	/// <summary>
	/// A position coordinate.
	/// </summary>
	public struct Position : IEquatable<Position>
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

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			return Equals((Position)obj);
		}

		public bool Equals(Position other)
		{
			return Column == other.Column && Row == other.Row;
		}

		public static bool operator ==(Position position1, Position position2)
		{
			return position1.Equals(position2);
		}

		public static bool operator !=(Position position1, Position position2)
		{
			return !position1.Equals(position2);
		}
	}
}
