using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class PromocaoModel
{
   public CategoriaEnum Categoria { get; set; }
   public decimal ValorDesconto { get; set; }
   public TipoDesconto TipoDesconto { get; set; }

   private List<ProdutoModel> _produtos = new List<ProdutoModel>();

   
   public decimal CalcularDesconto(decimal preco)
   {
      if (TipoDesconto == TipoDesconto.Porcentagem)
      {
         return preco * (ValorDesconto / 100);
      }
      else
      {
         return ValorDesconto;
      }
   }
}