using System;
using Xadrez.tabuleiro;
using Xadrez.Pecas;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Tabuleiro tab;

            tab = new Tabuleiro(8, 8);

            tab.ColocarPeca(new Torre(Enum.Cor.Preto, tab), new Posicao(0,0));
            tab.ColocarPeca(new Torre(Enum.Cor.Preto, tab), new Posicao(1, 3));
            tab.ColocarPeca(new Rei(Enum.Cor.Preto, tab), new Posicao(2, 4));

            Tela.ExibeTabuleiro(tab);


            Console.ReadLine();
            
        }
    }
}
