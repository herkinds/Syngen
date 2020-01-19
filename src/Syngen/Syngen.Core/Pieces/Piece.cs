using Syngen.Core.Board;
using Syngen.Core.Colours;

namespace Syngen.Core.Pieces
{
    public abstract class Piece : IPiece, IPositionable
    {
        public abstract char Abbreviation { get; }
        public abstract string Name { get; }
        public abstract int Value { get; }
        public Colour Colour { get; private set; }
        public Position Position { get; private set; }

        public override string ToString()
            => $"{Abbreviation} {Position.ToString()} ({Colour.ToString()})";
    }
}
