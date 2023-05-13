using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public abstract class ProdutoModel
{
    public long ProdutoID;
    public string Nome;
    public decimal Preco;
    public CategoriaEnum Categoria { get; set; }
    public decimal Desconto { get; set; }

    public ProdutoModel(long produtoID, string nome, decimal preco, decimal desconto)
    {
        ProdutoID = produtoID;
        Nome = nome;
        Preco = preco;
        Desconto = desconto;
    }

    public abstract decimal CalcularValorDoDesconto(PromocaoModel? promocao);
}