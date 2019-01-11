using Xadrez.Enum;

namespace Xadrez.tabuleiro
{
    class Peca
    {
        public Posicao Posicao { get; set;}
        public Cor Cor { get; protected set; }
        public Tabuleiro Tab { get; set; }
        public int QtdMovimento { get; protected set; }
        
        public Peca(Posicao posicao, Cor cor, Tabuleiro tab)
        {
            this.Posicao = posicao;
            this.Cor = cor;
            this.Tab = tab;
            QtdMovimento = 0;
        }
    }
}
