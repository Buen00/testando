using System;

namespace exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
           cliente cliente1 = new cliente(15, "Pedro", "Av. das Pedras", "Canoas", "RS", 92020305, 999482603, "Salada");
        	Fornecedor forne1 = new Fornecedor(51, "Alfredo", "Rua Caçapava", "Alvorada", "RS", 98065420,987263541, "1kg de batata", 568459416);
        	Livro livro1 = new Livro(98, "Dexter: Mão esquerda de Deus", "Jeff Lindsay", 9780752866765, 54, 251);
        	Pedido pedi1 = new Pedido(698, new DateTime(2019,08,19), "Dexter é delicioso", 3, 23);
        	PedidoCliente pedcli = new PedidoCliente(587, new DateTime(2019,08,15));
        	PedidoFornecedor pedfor = new PedidoFornecedor(745, new DateTime(2019,08,09));
        }
    }
}
