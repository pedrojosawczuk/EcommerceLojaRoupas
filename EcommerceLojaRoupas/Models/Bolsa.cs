using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class BolsaModel : AcessorioModel
{
   public string Material { get; set; }
   public int NumeroCompartimentos { get; set; }
   public BolsaModel(
            string material,
            int numeroCompartimentos,
            TamanhoAcessorio tamanhoAcessorio,
            CorAcessorio corAcessorio,
            long produtoID,
            string nome,
            decimal preco,
            decimal desconto
       ) : base(tamanhoAcessorio, corAcessorio, produtoID, nome, preco, desconto)
   {
      Material = material;
      NumeroCompartimentos = numeroCompartimentos;
   }

   public override decimal CalcularValorDoDesconto(PromocaoModel? promocao)
   {
      decimal desconto = 0;

      if (promocao == null)
      {
         return desconto;
      }

      if (promocao.TipoDesconto == TipoDesconto.Porcentagem)
      {
         desconto = (promocao.ValorDesconto / 100) * Preco;
      }
      else if (promocao.TipoDesconto == TipoDesconto.ValorFixo)
      {
         desconto = promocao.ValorDesconto;
      }
      return desconto;
   }
}