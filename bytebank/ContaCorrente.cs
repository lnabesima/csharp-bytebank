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
}