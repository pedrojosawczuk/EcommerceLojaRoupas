﻿using System.Collections.Generic;
using System;
using System.Runtime.InteropServices;

namespace Projeto_loja_Virtual
{
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
                Console.WriteLine("1 - Cadastrar Categoria");
                Console.WriteLine("2 - Listar Categorias");
                Console.WriteLine("3 - Cadastrar Produto");
                Console.WriteLine("4 - Listar Produtos");
                Console.WriteLine("5 - Cadastrar Cliente");
                Console.WriteLine("6 - Listar Clientes");
                Console.WriteLine("7 - Registrar Venda");
                Console.WriteLine("8 - Listar Vendas");
                Console.WriteLine("0 - Sair");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        .CadastrarCategoria(listaCategorias);
                        break;
                    case 2:
                        .ListarCategorias(listaCategorias);
                        break;
                    case 3:
                        .CadastrarProduto(listaProdutos, listaCategorias);
                        break;
                    case 4:
                        .ListarProdutos(listaProdutos);
                        break;
                    case 5:
                        .CadastrarCliente(listaClientes);
                        break;
                    case 6:
                        .ListarClientes(listaClientes);
                        break;
                    case 7:
                        .CadastrarVenda(listaVendas, listaClientes, listaProdutos);
                        break;
                    case 8:
                        .ListarVenda(listaVendas);
                        break;
                    case 0:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Digite novamente.");
                        break;
                }


                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 0);
        }
    }
}
