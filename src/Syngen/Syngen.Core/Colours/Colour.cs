namespace Syngen.Core.Colours
{
    public enum Colour : byte
    {
        White = 0b_0000,
        Black = 0b_1111
    }

    public static class ColourExtensions
    {
        public static Colour Switch(this Colour @this)
                => ~@this;

        public static bool IsWhite(this Colour @this)
                => @this == Colour.White;

        public static bool IsBlack(this Colour @this)
                => @this == Colour.Black;
    }
}
