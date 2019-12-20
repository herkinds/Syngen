namespace Syngen.Core.Pieces
{
    public sealed class Queen : AbstractPiece
    {
        public override char Abbreviation => 'Q';
        public override string Name => "Queen";
        public override uint Value => 9;
    }
}
