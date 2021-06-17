namespace SimpleChess
{
    class Rook : Piece
    {
        // Vi arver 'string Symbol' fra 'Piece'. Jeg prøvde først 'public Rook(string symbol) : base(symbol)' men innså seinere at vi ikke skal ta in noe.
        // Nå arver vi 'symbol' men vi setter symbol til å være "TRN" som var symbolet til 'Rook' før jeg endret på den.
        public Rook() : base("TRN")
        {

        }

        // En override som setter Move til hva 'Rook' gjorde fra før av.
        public override bool Move(string fromPosition, string toPosition)
        {
            return fromPosition[0] == toPosition[0] || fromPosition[1] == toPosition[1];
        }
    }
}