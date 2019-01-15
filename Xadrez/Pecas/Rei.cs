using System;
using Xadrez.Enum;
using Xadrez.tabuleiro;

namespace Xadrez.Pecas
{
    class Rei:Peca
    {
        public Rei(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "R";
        }
    }
}
