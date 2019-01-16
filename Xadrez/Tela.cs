﻿using System;
using Xadrez.tabuleiro;
using Xadrez.Enum;

namespace Xadrez
{
    class Tela
    {
        public static void ExibeTabuleiro(Tabuleiro tab)
        {
            for(int i=0; i<tab.Linha; i++)
            {
                Console.Write(8 - i + " ");
                for(int j=0; j<tab.Coluna; j++)
                {
                    if(tab.Peca(i,j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        ImprimirPeca(tab.Peca(i, j));
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("  A B C D E F G H");
        }

        public static void ImprimirPeca(Peca peca)
        {
            if (peca.Cor == Cor.Branco)
            {
                Console.Write(peca);
            }
            else
            {
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(peca);
                Console.ForegroundColor = aux;
            }
        }
    }
}
