namespace ecommerceLojaRoupas.Model;

public class Produto
{
    public long ProdutoID;
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public CategoriaProduto Categoria { get; set; }
}

public class Camisa : Produto
{
    public string? Tamanho { get; set; }
}

public class Calca : Produto
{
    public string? Cor { get; set; }
}

public class Blusa : Produto
{
    public string? Tecido { get; set; }
}

public class Saia : Produto
{
    public string? Comprimento { get; set; }
}

public class Acessorios : Produto
{
    public decimal Tamanho { get; set; }
    public string? Cor { get; set; }
}

public class Bolsa : Acessorios
{
    public string? Material { get; set; }
}

public class Sapato : Acessorios
{
    public string? Tipo { get; set; }
}

