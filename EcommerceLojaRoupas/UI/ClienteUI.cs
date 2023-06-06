using EcommerceLojaRoupas.Models;

namespace EcommerceLojaRoupas.UI;

//criar Clientes e Listar Clientes
class ClienteUI
{
    public static void CadastrarCliente(List<ClienteModel> listaClientes)
    {
        Console.Clear();
        Console.WriteLine("CADASTRO DE CLIENTE\n");

        Console.Write("Nome do cliente: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Sobrenome do cliente: ");
        string sobreNome = Console.ReadLine() ?? "";

        Console.Write("Endereco do cliente: ");
        string endereco = Console.ReadLine() ?? "";

        Console.Write("Telefone do cliente: ");
        string telefone = Console.ReadLine() ?? "";

        int id = listaClientes.Count + 1;

        ClienteModel cliente = new ClienteModel(id, nome, sobreNome, endereco, telefone);

        listaClientes.Add(cliente);

        Console.WriteLine("\nCliente cadastrado com sucesso!");
    }

    public static void ListarClientes(List<ClienteModel> listaClientes)
    {
        Console.Clear();
        Console.WriteLine("LISTAGEM DE CLIENTES\n");

        foreach (ClienteModel cliente in listaClientes)
        {
            Console.WriteLine("ID: " + cliente.ClienteID);
            Console.WriteLine("Nome: " + cliente.NomeCompleto);
            Console.WriteLine("E-mail: " + cliente.Telefone);
            Console.WriteLine("--------------------------");
        }
    }
}