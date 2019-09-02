namespace exercicio2
{
    public class Livro
    {
        public int codigo;
        public string titulo;
        public string autor;
        public double isbn;
        public float preco;
        public int codfornecedor;

        public Livro (  int codigo,
                        string titulo,
                        string autor,
                        double isbn,
                        float preco,
                        int codfornecedor)
        {
            this.codigo = codigo;
            this.titulo = titulo;
            this.autor = autor;
            this.isbn = isbn;
            this.preco = preco;
            this.codfornecedor = codfornecedor;
        }

        public void inserir (int cod, string ti, string au, double isb, float pre, int codf){
            this.codigo = cod;
            this.titulo = ti;
            this.autor = au;
            this.isbn = isb;
            this.preco = pre;
            this.codfornecedor = codf;
        }

        public void excluir (int cod){
            this.codigo = cod;
        }

        public void alterar (int cod, float pre, int codf){
            this.codfornecedor = cod;
            this.preco = pre;
            this.codfornecedor = codf;
        }

        public void consultar (int cod, string ti, string au){
            this.codigo = cod;
            this.titulo = ti;
            this.autor = au;
        }
    }
}