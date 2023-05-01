using System;
enum CategoriaProduto { 
    Camisa, 
    Calca, 
    Blusa, 
    Saia,
    Bolsa,
    Sapato,
    Colar
} 

public class Produto{
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
    public decimal Preco { get; set; }
    public CategoriaProduto Tipo { get; set; }
}

public class Camisa : Produto {
    public string? Tamanho { get; set; }
}

public class Calca : Produto {
    public string? Cor { get; set; }
}

public class Blusa : Produto {
    public string? Tecido { get; set; }
}

public class Saia : Produto {
    public string? Comprimento { get; set; }
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
// classe Cliente
class Cliente
{
    private int id;
    private string nome;
    private string email;

    public Cliente(int id, string nome, string email)
    {
        this.id = id;
        this.nome = nome;
        this.email = email;
    }

    public int Id { get => id; set => id = value; }
    public string Nome { get => nome; set => nome = value; }
    public string Email { get => email; set => email = value; }
}


// Classe Item venda
class Venda
    {
        private int id;
        private Cliente cliente;
        private List<ItemVenda> itensVenda = new List<ItemVenda>();

        public Venda(int id, Cliente cliente)
        {
            this.id = id;
            this.cliente = cliente;
        }

        public int Id { get => id; set => id = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Produto produto { get => produto; set => produto = value; }
        public List<ItemVenda> ItensVenda { get => itensVenda; set => itensVenda = value; }

        public decimal CalcularValorTotal()
        {
            decimal valorTotal = 0;
            foreach (ItemVenda item in itensVenda)
            {
                valorTotal += item.CalcularSubtotal();
            }
            return valorTotal;
        }
    }
