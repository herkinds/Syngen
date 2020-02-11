using Syngen.Core.Colours;

namespace Syngen.Core.Pieces
{
    /// <summary>
    /// Interface for chess pieces.
    /// </summary>
    public interface IPiece : IColourable
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
        /// Value of the piece.
        /// </summary>
        int Value { get; }
    }
}
