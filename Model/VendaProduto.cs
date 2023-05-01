namespace ecommerceLojaRoupas.Model;

public class VendaProduto
{
    public int VendaProdutoID;
    public Produto? _produto;
    public decimal _quantidade;
    public decimal _precoUnitario;

    public decimal _subtotal
    {
        get { return _quantidade * _precoUnitario; }
    }
}