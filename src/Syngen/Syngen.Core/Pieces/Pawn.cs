namespace Syngen.Core.Pieces
{
    public sealed class Pawn : Piece
    {
        public override char Abbreviation => ' ';
        public override string Name => "Pawn";
        public override int Value => 1;
    }
}
