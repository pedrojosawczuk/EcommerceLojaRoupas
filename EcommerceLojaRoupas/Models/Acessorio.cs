using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public abstract class AcessorioModel : ProdutoModel
{
    public TamanhoAcessorio Tamanho { get; set; }
    public CorAcessorio Cor { get; set; }

    public AcessorioModel(
        TamanhoAcessorio tamanhoAcessorio,
        CorAcessorio corAcessorio,
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
        Tamanho = tamanhoAcessorio;
        Cor = corAcessorio;
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
            // desconto de porcentagem específico para camisetas
            desconto = (promocao.ValorDesconto / 100) * Preco;
        }
        else if (promocao.TipoDesconto == TipoDesconto.ValorFixo)
        {
            // desconto de valor fixo específico para camisetas
            desconto = promocao.ValorDesconto;
        }
        return desconto;
    }
}