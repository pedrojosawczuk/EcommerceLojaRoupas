using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class CalcaModel : ProdutoModel
{
   public TamanhoCalca Tamanho { get; set; }
   public CorRoupa Cor { get; set; }

   public CalcaModel(
       TamanhoCalca tamanho,
       CorRoupa cor,
       long produtoID,
       string nome,
       decimal preco,
       decimal desconto
       ) : base(
           produtoID,
           nome,
           preco,
           desconto)
   {
      Tamanho = tamanho;
      Cor = cor;
   }
   public override decimal CalcularValorDoDesconto(PromocaoModel? promocao)
   {
      decimal desconto = 0;
      if (promocao != null)
      {
         if (promocao.TipoDesconto == TipoDesconto.Porcentagem)
         {
            // desconto de porcentagem específico para camisetas
            desconto = (promocao.ValorDesconto / 100) * Preco;
         }
         else if (promocao.TipoDesconto == TipoDesconto.ValorFixo)
         {
            // desconto de valor fixo específico para camisetas
            desconto = promocao.ValorDesconto;
         }
      }
      return Preco - desconto;
   }
}