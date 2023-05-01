public class Principal {
   public static Produto criarCategoria(CategoriaProduto categoria) {
      switch (categoria) {
         case Camisa:
            return new Camisa();
         case Calça:
            return new Gato();
         case Blusa:
            return new Blusa();
         default:
            throw new IllegalArgumentException("Tipo de animal inválido: " + categoria);
      }
   }
}