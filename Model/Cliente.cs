namespace ecommerceLojaRoupas.Model;

// classe Cliente
class Cliente
{
    public int ClienteID;
    private string _nome;
    private string _email;

    public Cliente(int id, string nome, string email)
    {
        this.ClienteID = id;
        this._nome = nome;
        this._email = email;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            try
            {
                this._nome = value;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
            }
        }
    }
    public string Email
    {
        get { return _email; }
        set
        {
            try
            {
                this._email = value;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine(" ❌ ERROR: " + ex.Message + " ❌ ");
            }
        }
    }
}
