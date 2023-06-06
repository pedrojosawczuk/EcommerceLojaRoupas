using EcommerceLojaRoupas.Models.Enums;
using EcommerceLojaRoupas.Models;
using EcommerceLojaRoupas.UI;
//using EcommerceLojaRoupas.Dados;

namespace EcommerceLojaRoupas;

class Program
{
    private List<ProdutoModel> listaProdutos = new List<ProdutoModel>();
    private List<CategoriaEnum> listaCategorias = new List<CategoriaEnum>();
    private List<ClienteModel> listaClientes = new List<ClienteModel>();
    private List<VendaModel> listaVendas = new List<VendaModel>();

    //new BaseDeDados(estoque).PopularBaseDeDados();
    void Main(string[] args)
    {
        int opcao = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("Escolha uma opção:");
            Console.WriteLine("1 - Listar Categorias");
            Console.WriteLine("2 - Cadastrar Produto");
            Console.WriteLine("3 - Listar Produtos");
            Console.WriteLine("4 - Cadastrar Cliente");
            Console.WriteLine("5 - Listar Clientes");
            Console.WriteLine("6 - Registrar Venda");
            Console.WriteLine("7 - Listar Vendas");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine() ?? "0");

            switch (opcao)
            {
                case 1:
                    CategoriaUI.ListarCategorias(listaCategorias);
                    break;
                case 2:
                    ProdutoUI.CadastrarProduto(listaProdutos, listaCategorias);
                    break;
                case 3:
                    ProdutoUI.ListarProdutos(listaProdutos);
                    break;
                case 4:
                    ClienteUI.CadastrarCliente(listaClientes);
                    break;
                case 5:
                    ClienteUI.ListarClientes(listaClientes);
                    break;
                case 6:
                    VendaUI.CadastrarVenda(listaVendas, listaClientes, listaProdutos);
                    break;
                case 7:
                    VendaUI.ListarVenda(listaVendas);
                    break;
                case 0:
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Digite novamente.");
                    break;
            }
            //CategoriaEnum tipo = CategoriaEnum.Camisa;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 0);
    }
}