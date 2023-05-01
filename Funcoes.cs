namespace ecommerceLojaRoupas.Model;

public class Principal {
   public static Produto criarCategoria(CategoriaProduto categoria) {
      switch (categoria) {
         case CategoriaProduto.Camisa:
            return new Camisa();
         case CategoriaProduto.Calca:
            return new Calca();
         case CategoriaProduto.Blusa:
            return new Blusa();
         default:
            throw new ArgumentException("Tipo de animal inválido: " + categoria);
      }
   }
}