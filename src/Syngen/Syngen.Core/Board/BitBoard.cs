using System;

namespace Syngen.Core
{
    public struct BitBoard
    {
        private ulong _internal;

        public BitBoard(ulong @internal)
        {
            _internal = @internal;
        }

        public BitBoard Merge(BitBoard other)
            => new BitBoard(_internal & other._internal);

        public BitBoard Complement()
            => new BitBoard(~_internal);

        public BitBoard Empty()
            => new BitBoard(0);

        public override string ToString()
        {
            return _internal.ToString();
        }
    }
}
