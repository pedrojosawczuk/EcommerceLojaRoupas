using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

public class EstoqueModel
{
    private List<ProdutoModel> _produtos;
    private List<PromocaoModel> promocoes;
    public EstoqueModel()
    {
        _produtos = new List<ProdutoModel>();
        promocoes = new List<PromocaoModel>();
    }

    public void AdicionarPromocao(PromocaoModel promocao)
    {
        foreach (var produto in _produtos)
        {
            if (promocao.Produtos().Contains(produto))
            {
                //produto.Desconto = promocao.ValorDesconto;
            }
        }
    }

    public void AdicionarProduto(ProdutoModel produto)
    {
        _produtos.Add(produto);
    }

    public List<ProdutoModel> ListarProdutos(int code)
    {
        List<ProdutoModel> produtosFiltrados = new List<ProdutoModel>();
        //foreach (var produto in _produtos)
        //{
        //    if (code == produto.Tipo)
        //    {
        //        produtosFiltrados.Add(produto);
        //    }
        //}
        return produtosFiltrados;
    }

    public void RemoverProduto(long produtoID)
    {
        var produto = _produtos.FirstOrDefault(p => p.ProdutoID == produtoID);
        if (produto != null)
        {
            _produtos.Remove(produto);
        }
    }
    public ProdutoModel ObterProdutoPorCodigo(int codigo)
    {
        return _produtos.FirstOrDefault(p => p.ProdutoID == codigo);
    }

    public ProdutoModel AdicionarProdutoNoCarrinho(long produtoID, int tipo)
    {
        List<ProdutoModel> produtosFiltrados = ListarProdutos(tipo);
        var produto = produtosFiltrados.FirstOrDefault(p => p.ProdutoID == produtoID);
        if (produto != null)
        {
            PromocaoModel promocao = promocoes.FirstOrDefault(pr => pr.Produtos().Contains(produto));
            if (promocao != null)
            {
                decimal desconto = 0;
                if (promocao.TipoDesconto == TipoDesconto.Porcentagem)
                {
                    desconto = produto.Preco * (promocao.ValorDesconto / 100);
                }
                else if (promocao.TipoDesconto == TipoDesconto.ValorFixo)
                {
                    desconto = promocao.ValorDesconto;
                }
                //produto.Desconto = desconto;
            }
            else
            {
                //produto.Desconto = 0;
            }
            _produtos.Remove(produto);
            return produto;
        }
        return null;
    }

    public List<ProdutoModel> ListarProdutosPorCategoria(string categoria)
    {
        List<ProdutoModel> produtosPorCategoria = new List<ProdutoModel>();
        foreach (ProdutoModel produto in _produtos)
        {
            if (Enum.TryParse(categoria, out CategoriaEnum categoriaProduto) && produto.Categoria == categoriaProduto)
            {
                produtosPorCategoria.Add(produto);
            }
        }
        return produtosPorCategoria;
    }
}