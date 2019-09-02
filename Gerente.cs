using System;

namespace exercicio2
{
    public class Gerente
    {

        cliente cliente;
        PedidoCliente PedidoCliente;
        PedidoFornecedor PedidoFornecedor;
        Pedido Pedido;
        Livro Livro;
        Fornecedor Fornecedor;


        public void enviarPedFornecedor (int cod, DateTime data){
            PedidoFornecedor.codfornecedor = cod;
            PedidoFornecedor.datarecebimento = data;
        }

        public void efetuarPagFornecedor (int cod, string ped, int cn){
            Fornecedor.codigo = cod;
            Fornecedor.pedfor = ped;
            Fornecedor.cnpj = cn;
        }

        public void inserir (   int codcli, string nomecli, string endcli, string cicli,string ufcli, int cecli, int fonecli,
                                int codli, string tili, string auli, double isbli, float preli, int codfli,
                                int codfor, string namefor, string endfor, string cifor, string uffor, int cefor, int fonefor, int cnfor){
            cliente.codigo = codcli;
            cliente.nome = nomecli;
            cliente.endereco = endcli;
            cliente.cidade = cicli;
            cliente.estado = ufcli;
            cliente.cep = cecli;
            cliente.telefone = fonecli;

            Livro.codigo = codli;
            Livro.titulo = tili;
            Livro.autor = auli;
            Livro.isbn = isbli;
            Livro.preco = preli;
            Livro.codfornecedor = codfli;

            Fornecedor.codigo = codfor;
            Fornecedor.nome = namefor;
            Fornecedor.endereco = endfor;
            Fornecedor.cidade = cifor;
            Fornecedor.estado = uffor;
            Fornecedor.cep = cefor;
            Fornecedor.telefone = fonecli;
            Fornecedor.cnpj = cnfor;
        }

        public void excluir (int codcli, int codfor, int codli){
            cliente.codigo = codcli;
            Fornecedor.codigo = codfor;
            Livro.codigo = codli;
        }

        public void alterar (int codcli, int codfor, int codli){
            cliente.codigo = codcli;
            Fornecedor.codigo = codfor;
            Livro.codigo = codli;
        }

        public void consultar (string nomecli, string ti, string au, string nomefor){
            cliente.nome = nomecli;
            Livro.titulo = ti;
            Livro.autor = au;
            Fornecedor.nome = nomefor;
        }

        public void imprimirRelPedCliente (string ped){
            cliente.pedcli = ped;
        }

        public void imprimirRelClientes (int cod){
            cliente.codigo = cod;
        }

        public void imprimirRelFornecedores (int cod){
            Fornecedor.codigo = cod;
        }

        public void imprimirRelPedFornecedores (string ped){
            Fornecedor.pedfor = ped;
        }

        public void remessaCliente (int cod, DateTime data){
            PedidoCliente.codcliente = cod;
            PedidoCliente.dataremessa = data;
        }
    }
}