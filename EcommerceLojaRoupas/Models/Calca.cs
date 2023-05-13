using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class CalcaModel : ProdutoModel
{
    public TamanhoCalca Tamanho { get; set; }
    public CorRoupa Cor { get; set; }


    public override decimal CalcularValorDoDesconto(PromocaoModel promocao)
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