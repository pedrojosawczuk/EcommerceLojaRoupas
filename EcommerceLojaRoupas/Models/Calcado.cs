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
}