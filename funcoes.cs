
// Criar Produtos e listar produtos
class ProdutoUI
{
   public static void CadastrarProduto(List<Produto> listaProdutos, List<Categoria> listaCategorias)
   {
      Console.Clear();
      Console.WriteLine("CADASTRO DE PRODUTO\n");

      Console.Write("Nome do produto: ");
      string nome = Console.ReadLine();

      Console.Write("Descrição do produto: ");
      string descricao = Console.ReadLine();

      Console.Write("Preço do produto: ");
      decimal preco = decimal.Parse(Console.ReadLine());

      Console.WriteLine("\nSelecione a categoria do produto:");

      CategoriaUI.ListarCategorias(listaCategorias);

      Console.Write("Digite o ID da categoria: ");
      int idCategoria = int.Parse(Console.ReadLine());

      Categoria categoria = listaCategorias.Find(c => c.Id == idCategoria);

      int id = listaProdutos.Count + 1;

      Produto produto = new Produto(id, nome, descricao, categoria, preco);

      listaProdutos.Add(produto);

      Console.WriteLine("\nProduto cadastrado com sucesso!");
   }

   public static void ListarProdutos(List<Produto> listaProdutos)
   {
      Console.Clear();
      Console.WriteLine("LISTAGEM DE PRODUTOS\n");

      foreach (Produto produto in listaProdutos)
      {
            Console.WriteLine("ID: " + produto.Id);
            Console.WriteLine("Nome: " + produto.Nome);
            Console.WriteLine("Descrição: " + produto.Descricao);
            Console.WriteLine("Preço: " + produto.Preco.ToString("C2"));
            Console.WriteLine("Categoria: " + produto.Categoria.Nome);
            Console.WriteLine("--------------------------");
      }
   }
}

//criar Clientes e Listar Clientes
class ClienteUI
{
   public static void CadastrarCliente(List<Cliente> listaClientes)
   {
      Console.Clear();
      Console.WriteLine("CADASTRO DE CLIENTE\n");

      Console.Write("Nome do cliente: ");
      string nome = Console.ReadLine();

      Console.Write("E-mail do cliente: ");
      string email = Console.ReadLine();

      int id = listaClientes.Count + 1;

      Cliente cliente = new Cliente(id, nome, email);

      listaClientes.Add(cliente);

      Console.WriteLine("\nCliente cadastrado com sucesso!");
   }

   public static void ListarClientes(List<Cliente> listaClientes)
   {
      Console.Clear();
      Console.WriteLine("LISTAGEM DE CLIENTES\n");

      foreach (Cliente cliente in listaClientes)
      {
            Console.WriteLine("ID: " + cliente.Id);
            Console.WriteLine("Nome: " + cliente.Nome);
            Console.WriteLine("E-mail: " + cliente.Email);
            Console.WriteLine("--------------------------");
      }
   }
   
}

// Criar Venda e listar Vendas
class VendaUI
{
   public static void CadastrarVenda(List<Venda> listavendas, List<Cliente> listaClientes, List<Produto> listaProdutos)
   {
      Console.Clear();
      Console.WriteLine("CADASTRO DE Venda\n");

      Console.WriteLine("\nSelecione o Cliente:");

      ClienteUI.ListarClientes(listaClientes);

      Console.Write("Digite o ID da categoria: ");
      int idCliente = int.Parse(Console.ReadLine());
      Cliente Cliente = listaClientes.Find(c => c.Id == idCliente);
      int id = listavendas.Count + 1;
      Venda venda = new Venda(id, Cliente);
      listavendas.Add(venda);
      char x = 'S';
      while (x== 's' || x == 'S')
      {
            Console.Clear();
            Console.WriteLine("== Adicionar item à venda ==");

            // Lista todos os produtos cadastrados
            Console.WriteLine("\nProdutos disponíveis:");
            foreach (Produto p in listaProdutos)
            {
               Console.WriteLine($"ID: {p.Id} | Produto: {p.Nome} | Preço: {p.Preco:C}");
            }
            Console.Write("\nDigite o ID do produto que deseja adicionar: ");
            int idProduto = int.Parse(Console.ReadLine());

            // Busca o produto com o ID informado na lista de produtos
            Produto produto = listaProdutos.Find(x => x.Id == idProduto);

            if (produto == null)
            {
               Console.WriteLine("\nProduto não encontrado!");
            }
            else
            {
               Console.Write("Digite a quantidade desejada: ");
               int quantidade = int.Parse(Console.ReadLine());

               // Cria um objeto ItemVenda e adiciona à lista de itens da venda
               ItemVenda item = new ItemVenda(produto, quantidade);
               venda.ItensVenda.Add(item);
               Console.WriteLine("\nItem adicionado à venda!");

               Console.Write("\nDeseja adicionar mais um item à venda? (S/N) ");
               x = char.Parse(Console.ReadLine());
            }
      }
      Console.WriteLine("\nVenda cadastrado com sucesso!");
   }

   public static void ListarVenda(List<Venda> listaVendas)
   {
      if (listaVendas.Count == 0)
      {
            Console.WriteLine("Não há vendas registradas.");
      }
      else
      {
            Console.WriteLine("Vendas registradas:");
            foreach (Venda venda in listaVendas)
            {
               Console.WriteLine($"ID da Venda: {venda.Id}");
               Console.WriteLine($"Nome do Cliente: {venda.Cliente.Nome}");
               Console.WriteLine("Produtos:");
               foreach (ItemVenda item in venda.ItensVenda)
               {
                  Console.WriteLine($"- {item.Produto.Nome}:");
                  Console.WriteLine($"  Preço individual: R${item.Produto.Preco:F2}");
                  Console.WriteLine($"  Quantidade comprada: {item.Quantidade}");
               }
               Console.WriteLine($"Preço total da compra: R${venda.CalcularValorTotal():F2}\n");
            }
      }
   }

}



