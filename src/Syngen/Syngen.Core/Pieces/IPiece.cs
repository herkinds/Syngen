using Syngen.Core.Colours;

namespace Syngen.Core.Pieces
{
    public interface IPiece : IColourable
    {
        char Abbreviation { get; }
        string Name { get; }
        int Value { get; }
    }
}
