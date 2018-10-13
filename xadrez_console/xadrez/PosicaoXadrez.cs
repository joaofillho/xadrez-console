using tabuleiro;

namespace xadrez
{
    class PosicaoXadrez
    {
        //8
        //7
        //6
        //5
        //4        'C', 7    1,2     'A',8   0,0
        //3
        //2
        //1
        //    A   B  C  D   E  F   G   H


        public char coluna { get; set; }
        public int linha { get; set; }

        public PosicaoXadrez(char coluna, int linha)
        {
            this.coluna = coluna;
            this.linha = linha;
        }

        public Posicao toPosicao()
        {
            return new Posicao(8 - linha, coluna - 'a');
        }

        public override string ToString()
        {
            return "" + coluna + linha;
        }
    }
}
