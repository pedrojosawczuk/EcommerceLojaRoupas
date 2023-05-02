using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;
using ecommerceLojaRoupas.Model;
using ecommerceLojaRoupas.UI;

namespace ecommerceLojaRoupas;

class Program
{
    static List<Produto> listaProdutos = new List<Produto>();
    static List<CategoriaProduto> listaCategorias = new List<CategoriaProduto>();
    static List<Cliente> listaClientes = new List<Cliente>();
    static List<Venda> listaVendas = new List<Venda>();

    static void Main(string[] args)
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
            opcao = int.Parse(Console.ReadLine());

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
            //CategoriaProduto tipo = CategoriaProduto.Camisa;
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();

        } while (opcao != 0);
    }
}