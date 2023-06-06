using EcommerceLojaRoupas.Models;
using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.UI;

// Criar Categorias e listar categorias
class CategoriaUI
{
    public static void ListarCategorias(List<CategoriaEnum> listacategorias)
    {
        Console.Clear();
        Console.WriteLine("LISTAGEM DE CATEGORIAS\n");

        foreach (CategoriaEnum categoria in Enum.GetValues(typeof(CategoriaEnum)))
        {
            Console.WriteLine("Nome: " + categoria.ToString());
            Console.WriteLine("--------------------------");
        }
    }
}