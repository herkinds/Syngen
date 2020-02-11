namespace Syngen.Core.Board
{
    public struct Position : IPosition
    {
        public Position(byte x, byte y)
        {
            X = x;
            Y = y;
        }

        public byte X { get; }

        public byte Y { get; }
    }
}
