namespace bytebank;

public class ContaCorrente
{
    public ContaCorrente(Cliente titular, string nome_agencia, int numero_agencia, string numero_conta)
    {
        this.Nome_Agencia = nome_agencia;
        this.Agencia = numero_agencia;
        this.Conta = numero_conta;
        this.Titular = titular;
        TotalDeContasCriadas++;
    }
    
    public static int TotalDeContasCriadas { get; private set; }
    public string Nome_Agencia { get; set; }
    public int Agencia { get;  }
    public string Conta { get;}  
    

    public Cliente Titular { get; set; }

    private double saldo;

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (this.saldo > valor)
        {
            this.saldo -= valor;
            return true;
        }
        else
        {
            Console.WriteLine("Esta conta não possui saldo suficiente para realizar esta operação.");
            return false;
        }
    }

    public bool Transferir(double valor, ContaCorrente destino)
    {
        if (destino != null && this.saldo > valor)
        {
            this.Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
        else
        {
            Console.WriteLine("O saldo da conta de origem é insuficiente para realizar esta transação.");
            return false;
        }
    }

    public void SetSaldo(double valor)
    {
        if (valor < 0)
        {
            return;
        }
        else
        {
            this.saldo = valor;
        }
    }

    public double GetSaldo()
    {
        return this.saldo;
    }

    public void MostraInformacoes()
    {
        Console.WriteLine("Os dados da conta são os seguintes:");
        Console.WriteLine($"Titular: {this.Titular}");
        Console.WriteLine($"Número da agência: {Agencia}");
        Console.WriteLine($"Número da conta: {Conta}");
        Console.WriteLine($"Saldo atual: {saldo}");
    }
}