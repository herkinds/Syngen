using Syngen.Core.Colours;

namespace Syngen.Core.Pieces
{
    /// <summary>
    /// Interface for chess pieces.
    /// </summary>
    public interface IPiece : IColourable
    {
        char Abbreviation { get; }
        string Name { get; }
        int Value { get; }
    }
}
