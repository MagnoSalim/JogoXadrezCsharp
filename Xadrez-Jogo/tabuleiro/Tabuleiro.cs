using System;

namespace tabuleiro
{
    class Tabuleiro
    {

        public int linhas { get; set; }
        public int colunas { get; set; }
        private Peca[,] pecas;

        public Tabuleiro(int linhas, int colunas)
        {
            this.linhas = linhas;
            this.colunas = colunas;
            pecas = new Peca[linhas, colunas];
        }

        /*--- Metodo para adicionar uma linha e uma coluna na Matriz <<Peca>> ---*/
        public Peca peca(int linha, int coluna)
        {
            return pecas[linha, coluna];
        }
        /*--- Metodo para adicionar uma linha e uma coluna na Matriz <<Peca>> ---*/
        public Peca peca(Posicao pos)
        {
            return pecas[pos.linha, pos.coluna];
        }
        /*--- Metodo para validar se existe peca na posicao desejada ---*/
        public bool existePeca(Posicao pos)
        {
            validarPosicao(pos);
            return peca(pos) != null;
        }
        /*--- Metodo para colocar uma peca na posicao <<pos>>---*/
        public void colocarPeca(Peca p, Posicao pos)
        {
            if (existePeca(pos))
            {
                throw new TabuleiroException("Já existe uma peça nessa posição!");
            }
            pecas[pos.linha, pos.coluna] = p;
            p.posicao = pos;
        }
        /*--- Metodo para verificar a posicão ---*/
        public bool posicaoValida(Posicao pos)
        {
            if (pos.linha < 0 || pos.linha >= linhas || pos.coluna < 0 || pos.coluna >= colunas)
            {
                return false;
            }
            return true;
        }
        /*Metodo para validar a posicao*/
        public void validarPosicao(Posicao pos)
        {
            if (!posicaoValida(pos))
            {
                throw new TabuleiroException("Posicão inválida!");
            }
        }

    }
}
