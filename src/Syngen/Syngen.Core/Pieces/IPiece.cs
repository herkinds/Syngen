using Syngen.Core.Colours;

namespace Syngen.Core.Pieces
{
    public interface IPiece : IColourable
    {
        char Abbreviation { get; }
        string Name { get; }
        uint Value { get; }
    }
}
