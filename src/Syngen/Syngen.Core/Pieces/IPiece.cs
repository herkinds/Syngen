using Syngen.Core.Colours;

namespace Syngen.Core.Pieces
{
    /// <summary>
    /// Interface for chess pieces.
    /// </summary>
    public interface IPiece
    {
        /// <summary>
        /// Abbreviation for the chess notation.
        /// </summary>
        char Abbreviation { get; }

        /// <summary>
        /// Name of the piece.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Colour of the piece.
        /// </summary>
        Colour Colour { get; }

        /// <summary>
        /// Value of the piece.
        /// </summary>
        int Value { get; }
    }
}
