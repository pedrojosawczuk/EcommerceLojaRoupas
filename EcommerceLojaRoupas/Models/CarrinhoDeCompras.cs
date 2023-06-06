using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class CarrinhoDeCompras
{
   public List<ProdutoModel> Produtos { get; set; } = new List<ProdutoModel>();
   public List<PromocaoModel> Promocoes { get; set; } = new List<PromocaoModel>();

   public void AdicionarProduto(ProdutoModel produto)
   {
      Produtos.Add(produto);
   }
   public void ListarProdutos()
   {
      if (Produtos.Any())
      {
         Console.WriteLine("Produtos no carrinho:");
         foreach (var produto in Produtos)
         {
            Console.WriteLine($"{produto.ProdutoID} - {produto.Nome} ({produto.Preco:C2})");
         }
      }
      else
      {
         Console.WriteLine("O carrinho está vazio.");
      }
   }

   public decimal ObterValorTotal()
   {
      decimal valorTotal = Produtos.Sum(produto => produto.Preco);

      foreach (var promocao in Promocoes)
      {
         if (promocao.TipoDesconto == TipoDesconto.Porcentagem)
         {
            valorTotal -= (promocao.ValorDesconto / 100) * valorTotal;
         }
         else
         {
            valorTotal -= promocao.ValorDesconto;
         }
      }

      return valorTotal;
   }
   public void AplicarPromocao(PromocaoModel promocao)
   {
      Console.WriteLine("contador = ");
      foreach (var produto in Produtos)
      {

         Console.WriteLine("entrou");
         if (promocao.Produtos.Contains(produto))
         {
            Console.WriteLine("val desc=" + promocao.ValorDesconto);
            produto.Desconto = promocao.ValorDesconto;
         }
      }
   }
}