using System;
using Xadrez.tabuleiro;
using Xadrez.Pecas;
using Xadrez.Exception;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            PosicaoXadrez pos = new PosicaoXadrez('a', 1);

            Console.WriteLine(pos);

            Console.WriteLine(pos.ToPosicao());


            /*Tabuleiro tab;

            tab = new Tabuleiro(8, 8);

            try
            {
                tab.ColocarPeca(new Torre(Enum.Cor.Preto, tab), new Posicao(0, 0));
                tab.ColocarPeca(new Torre(Enum.Cor.Preto, tab), new Posicao(1, 3));
                tab.ColocarPeca(new Rei(Enum.Cor.Preto, tab), new Posicao(2, 4));

                Tela.ExibeTabuleiro(tab);
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            */
            Console.ReadLine();
            
        }
    }
}
