using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class CalcadoModel : AcessorioModel
{
   public TamanhoSapato TamanhoSapato { get; set; }
   public string Marca { get; set; }

   public CalcadoModel(
       TamanhoSapato tamanhoSapato,
       string marca,
       TamanhoAcessorio tamanhoAcessorio,
       long produtoID, string nome, decimal preco, decimal desconto,
       CorAcessorio corAcessorio
       ) : base(
           tamanhoAcessorio,
           corAcessorio,
           produtoID,
           nome,
           preco,
           desconto)
   {
      TamanhoSapato = tamanhoSapato;
      Marca = marca;
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