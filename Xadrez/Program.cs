using System;
using Xadrez.tabuleiro;
using Xadrez.Pecas;
using Xadrez.Exception;
using Xadrez.Enum;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            /*PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());*/


            Tabuleiro tab;

            tab = new Tabuleiro(8, 8);

            try
            {
                tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Cor.Preto, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Cor.Preto, tab), new Posicao(2, 4));

                tab.ColocarPeca(new Torre(Cor.Branco, tab), new Posicao(3, 5));

                Tela.ExibeTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
            
        }
    }
}
