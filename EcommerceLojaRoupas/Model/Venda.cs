using EcommerceLojaRoupas.Models.Enums;

namespace EcommerceLojaRoupas.Models;

class VendaModel
{
    public int VendaID;
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
