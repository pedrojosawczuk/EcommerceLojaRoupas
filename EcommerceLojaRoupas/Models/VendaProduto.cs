namespace EcommerceLojaRoupas.Models;

public class VendaProdutoModel
{
    public int VendaProdutoID;
    public ProdutoModel? _produto;
    public decimal _quantidade;
    public decimal _precoUnitario;

    public decimal _subtotal
    {
        get { return _quantidade * _precoUnitario; }
    }
}