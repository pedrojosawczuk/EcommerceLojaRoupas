namespace ecommerceLojaRoupas.Model;

class Cliente
{
    public long ClienteID;
    public string Nome = string.Empty;
    //public string Sobrenome = string.Empty;
    public string Email = string.Empty;
    //public string Telefone = string.Empty;
    //public string Endereco = string.Empty;

    public Cliente(long id, string nome, string email)
    {
        ClienteID = id;
        Nome = nome;
        Email = email;
    }
}
