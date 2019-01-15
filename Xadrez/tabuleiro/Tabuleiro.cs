using Xadrez.Exception;

namespace Xadrez.tabuleiro
{
    class Tabuleiro
    {
        public int Linha { get; set; }
        public int Coluna { get; set; }
        private Peca[,] Pecas;

        public Tabuleiro(int linha, int coluna)
        {
            this.Linha = linha;
            this.Coluna = coluna;
            this.Pecas = new Peca[Linha, Coluna];
        }

        public Peca Peca(int linha, int coluna)
        {
            return Pecas[linha, coluna];
        }

        public Peca Peca(Posicao pos)
        {
            return Pecas[pos.Linha, pos.Coluna];
        }

        public bool ExistePeca(Posicao pos)
        {
            ValidaPosicao(pos);
            return Peca(pos) != null;
        }

      
        public void ColocarPeca(Peca p, Posicao pos)
        {
            Pecas[pos.Linha, pos.Coluna] = p;
            p.Posicao = pos;
        }

        public bool PosicaoValida(Posicao pos)
        {
            if(pos.Linha<0 || pos.Linha>=Linha || pos.Coluna<0 || pos.Coluna >= Coluna)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void ValidaPosicao(Posicao pos)
        {
            if (!PosicaoValida(pos))
            {
                throw new TabuleiroException("Posição Inválida!");
            }
        }
    }
}
