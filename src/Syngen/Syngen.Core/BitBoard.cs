namespace Syngen.Core
{
    public struct BitBoard
    {
        public static BitBoard Empty
            => new BitBoard(0);

        private readonly ulong _value;

        public BitBoard(ulong value)
        {
            _value = value;
        }

        public BitBoard Merge(BitBoard other)
            => new BitBoard(_value & other._value);

        public BitBoard Complement()
            => new BitBoard(~_value);

        public override string ToString()
            => _value.ToString();

        public override bool Equals(object obj)
            => _value.Equals(obj);

        public override int GetHashCode()
            => _value.GetHashCode();

        public static implicit operator ulong(BitBoard board)
            => board._value;
    }
}
