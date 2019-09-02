using System;

namespace exercicio2
{
    public class Pedido
    {
        public int codigo;
        public DateTime datapedido;
        public string listalivros;
        public int quantidade;
        public float valor;

        public Pedido ( int codigo,
                        DateTime datapedido,
                        string listalivros,
                        int quantidade,
                        float valor)
        {
            this.codigo = codigo;
            this.datapedido = datapedido;
            this.listalivros = listalivros;
            this.quantidade = quantidade;
            this.valor = valor;
        }

        public void calcvalor (float v){
            this.valor += v;
        }
    }
}