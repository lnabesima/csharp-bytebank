namespace bytebank;

public class Cliente
{
    public Cliente()
    {
        TotalDeClientes++;
    }
    
    public static int TotalDeClientes { get; private set; }
    
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Profissao { get; set; }
}