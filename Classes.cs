public abstract class Produto
{
    public string? Nome { get; set; }
    public decimal Preco { get; set; }
    public string? Descricao {get; set; }
}

public class Categoria
{
    
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

public class acessorios : Produto
{
    public decimal tamanho{ get; set; }
    public string? cor { get; set; }
}

public class Bolsa : acessorios
{

}

public class Sapato : acessorios
{

}

public class Sistemadecarrinho
{

}
