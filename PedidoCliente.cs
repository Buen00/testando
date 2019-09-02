using System;

namespace exercicio2
{
    public class PedidoCliente
    {
        public int codcliente;
        public DateTime dataremessa;

        public PedidoCliente (int codcliente,
                                DateTime datameessa)
        {
            this.codcliente = codcliente;
            this.dataremessa = datameessa;
        }

        public void pagamentoCliente(int cod){
            this.codcliente = cod;
        }

        public void remessaCliente(int cod, DateTime data){
            this.codcliente = cod;
            this.dataremessa = data;
        }

        public void recuperarPedCliente(int cod){
            this.codcliente = cod;
        }
    }
}