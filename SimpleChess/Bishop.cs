using System;

namespace SimpleChess
{
    class Bishop : Piece
    {
        // Vi arver 'string Symbol' fra 'Piece'. Jeg prøvde først 'public Bishop(string symbol) : base(symbol)' men innså seinere at vi ikke skal ta in noe.
        // Nå arver vi 'symbol' men vi setter symbol til å være "LPR" som var symbolet til 'Bishop' før jeg endret på den.
        public Bishop() : base("LPR")
        {
        }

        // En override som setter Move til hva 'Bishop' gjorde fra før av.
        public override bool Move(string fromPosition, string toPosition)
        {
            var diffCol = fromPosition[0] - toPosition[0];
            var diffRow = fromPosition[1] - toPosition[1];
            Console.WriteLine(diffCol);
            return Math.Abs(diffRow) == Math.Abs(diffCol);
        }
    }
}