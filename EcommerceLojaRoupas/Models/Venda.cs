using EcommerceLojaRoupas.Models;

namespace EcommerceLojaRoupas.Models;

class VendaModel
{
   public long VendaID { get; private set; }
   public ClienteModel? Cliente;
   public List<VendaProdutoModel>? Produtos;
   public decimal TotalCompra
   {
      get
      {
         try
         {
            return Produtos!.Sum(p => p._subtotal);
         }
         catch (NullReferenceException nrfe)
         {
            throw new Exception($"Nota sem venda: {nrfe.Message}");
         }
      }
   }
}
