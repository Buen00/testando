using System;

namespace exercicio2
{
    public class PedidoFornecedor
    {
        public int codfornecedor;
        public DateTime datarecebimento;

        public PedidoFornecedor (   int codfornecedor,
                                    DateTime datarecebimento)
        {
            this.codfornecedor = codfornecedor;
            this.datarecebimento = datarecebimento;
        } 

        public void pagamentoFornecedor (DateTime data){
            this.datarecebimento = data;
        }

        public void recuperarPedFornecedor (int cod){
            this.codfornecedor = cod;
        }
    }
}