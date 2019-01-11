using System;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            Posicao p;
            Tabuleiro tab;

            p = new Posicao(3, 4);
            tab = new Tabuleiro(8, 8);

            Console.WriteLine("Posição: " + p);

            Console.ReadLine();
            
        }
    }
}
