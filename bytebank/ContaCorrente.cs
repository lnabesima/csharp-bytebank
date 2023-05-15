namespace bytebank;

public class ContaCorrente
{
    public int agencia;
    public string conta;
    public string titular;
    public double saldo;

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
}