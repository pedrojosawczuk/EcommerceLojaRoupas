using EcommerceLojaRoupas.Model;

namespace EcommerceLojaRoupas.UI;

// Criar Categorias e listar categorias
class CategoriaUI
{
    public static void ListarCategorias(List<Categoria> listacategorias)
    {
        Console.Clear();
        Console.WriteLine("LISTAGEM DE CATEGORIAS\n");

        foreach (Categoria categoria in Enum.GetValues(typeof(Categoria)))
        {
            Console.WriteLine("Nome: " + categoria.ToString());
            Console.WriteLine("--------------------------");
        }
    }
}