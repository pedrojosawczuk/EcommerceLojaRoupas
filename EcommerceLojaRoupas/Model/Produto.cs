namespace ecommerceLojaRoupas.Model;

public class Produto
{
    public long ProdutoID;
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public Categoria? Categoria { get; set; }

    public Produto(long id, string nome, string descricao, Categoria categoria, decimal preco)
    {
        ProdutoID = id;
        Nome = nome;
        Descricao = descricao;
        Categoria = categoria;
        Preco = preco;
    }
}

public class Camisa : Produto
{
    public string? Tamanho { get; set; }
    public Camisa(long id, string nome, string descricao, Categoria categoria, decimal preco, string tamanho) : base(id, nome, descricao, categoria, preco)
    {
        Tamanho = tamanho;
    }
}

public class Calca : Produto
{
    public string? Cor { get; set; }

    public Calca(long id, string nome, string descricao, Categoria categoria, decimal preco, string cor) : base(id, nome, descricao, categoria, preco)
    {
        Cor = cor;
    }
}

public class Blusa : Produto
{
    public string? Tecido { get; set; }

    public Blusa(long id, string nome, string descricao, Categoria categoria, decimal preco, string tecido) : base(id, nome, descricao, categoria, preco)
    {
        Tecido = tecido;
    }
}

public class Saia : Produto
{
    public string? Comprimento { get; set; }

    public Saia(long id, string nome, string descricao, Categoria categoria, decimal preco, string comprimento) : base(id, nome, descricao, categoria, preco)
    {
        Comprimento = comprimento;
    }
}

public class Acessorios : Produto
{
    public decimal Tamanho { get; set; }
    public string? Cor { get; set; }

    public Acessorios(long id, string nome, string descricao, Categoria categoria, decimal preco, decimal tamanho, string cor) : base(id, nome, descricao, categoria, preco)
    {
        Tamanho = tamanho;
        Cor = cor;
    }
}

public class Bolsa : Acessorios
{
    public string? Material { get; set; }

    public Bolsa(long id, string nome, string descricao, Categoria categoria, decimal preco, decimal tamanho, string cor, string material) : base(id, nome, descricao, categoria, preco, tamanho, cor)
    {
        Material = material;
    }
}

public class Sapato : Acessorios
{
    public string? Tipo { get; set; }

    public Sapato(long id, string nome, string descricao, Categoria categoria, decimal preco, decimal tamanho, string cor, string tipo) : base(id, nome, descricao, categoria, preco, tamanho, cor)
    {
        Tipo = tipo;
    }
}