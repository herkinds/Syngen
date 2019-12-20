namespace Syngen.Core.Pieces
{
    public sealed class Pawn : AbstractPiece
    {
        public override char Abbreviation => ' ';
        public override string Name => "Pawn";
        public override uint Value => 1;
    }
}
