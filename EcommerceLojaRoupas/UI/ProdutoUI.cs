using EcommerceLojaRoupas.Models;
using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.UI;

// Criar Produtos e listar produtos
class ProdutoUI
{
    public static void CadastrarProduto(List<ProdutoModel> listaProdutos, List<CategoriaEnum> listaCategorias)
    {
        Console.Clear();
        Console.WriteLine("CADASTRO DE PRODUTO\n");

        Console.Write("Nome do produto: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Preço do produto: ");
        decimal preco = decimal.Parse(Console.ReadLine() ?? "");

        Console.WriteLine("\nSelecione a categoria do produto:");

        CategoriaUI.ListarCategorias(listaCategorias);

        Console.Write("Digite o ID da categoria: ");
        int idCategoria = int.Parse(Console.ReadLine() ?? "");

        ProdutoModel categoria = listaCategorias.Find(c => c.Id == idCategoria);

        Console.Write("Descrição do produto: ");
        string desconto = Console.ReadLine() ?? "";

        int id = listaProdutos.Count + 1;

        ProdutoModel produto = new ProdutoModel(id, nome, preco, categoria, desconto);

        listaProdutos.Add(produto);

        Console.WriteLine("\nProduto cadastrado com sucesso!");
    }

    public static void ListarProdutos(List<ProdutoModel> listaProdutos)
    {
        Console.Clear();
        Console.WriteLine("LISTAGEM DE PRODUTOS\n");

        foreach (ProdutoModel produto in listaProdutos)
        {
            Console.WriteLine("ID: " + produto.ProdutoID);
            Console.WriteLine("Nome: " + produto.Nome);
            Console.WriteLine("Descrição: " + produto.Preco);
            Console.WriteLine("Preço: " + produto.Preco.ToString("C2"));
            Console.WriteLine("Categoria: " + produto.Categoria.ToString());
            Console.WriteLine("--------------------------");
        }
    }
}