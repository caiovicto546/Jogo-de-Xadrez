using System;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Tabuleiro tab;
            

            tab = new Tabuleiro(8, 8);

            Tela.ExibeTabuleiro(tab);


            Console.ReadLine();
            
        }
    }
}
