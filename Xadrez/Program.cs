using System;
using Xadrez.Exception;
using Xadrez.Game;
using Xadrez.tabuleiro;

namespace Xadrez
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PartidaDeXadrez partida = new PartidaDeXadrez();

                while (!partida.Terminada)
                {
                    Posicao origem;
                    Posicao destino;

                    Console.Clear();
                    Tela.ExibeTabuleiro(partida.Tab);

                    Console.Write("Origem: ");
                    origem = Tela.LerPosicaoXadrez().ToPosicao();

                    Console.Write("Destino: ");
                    destino = Tela.LerPosicaoXadrez().ToPosicao();

                    partida.ExecutaMovimento(origem, destino);
                }

                
            }
            catch (TabuleiroException e)
            {
                Console.WriteLine(e.Message);
            }
            
            Console.ReadLine();
            
        }
    }
}
