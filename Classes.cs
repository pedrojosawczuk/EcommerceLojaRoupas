public class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
}

enum CategoriaProduto {
    Camisa,
    Calça,
    Blusa,
    Saia,
    Bolsa,
    Sapato,
    Colares
}

public class Acessórios:Produto
{
    public decimal tamanho{ get; set; }
    public string? cor { get; set; }
}