namespace ecommerceLojaRoupas.Model;

class Venda
{
    public int VendaID;
    public Cliente? Cliente;
    public List<VendaProduto>? Produtos;
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
