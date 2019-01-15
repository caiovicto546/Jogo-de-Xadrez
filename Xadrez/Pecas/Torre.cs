using System;
using Xadrez.Enum;
using Xadrez.tabuleiro;

namespace Xadrez.Pecas
{
    class Torre:Peca
    {
        public Torre(Cor cor, Tabuleiro tab) : base(cor, tab)
        {
        }

        public override string ToString()
        {
            return "T";
        }
    }
}
