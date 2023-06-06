namespace EcommerceLojaRoupas.Models;

public class Principal
{
    public static Produto criarCategoria(CategoriaEnum categoria)
    {
        switch (categoria)
        {
            case CategoriaEnum.Camisa:
                return new Camisa();
            case CategoriaEnum.Calca:
                return new Calca();
            case CategoriaEnum.Blusa:
                return new Blusa();
            default:
                throw new ArgumentException("Tipo de animal inválido: " + categoria);
        }
    }
}