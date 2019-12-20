namespace Syngen.Core.Colours
{
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
