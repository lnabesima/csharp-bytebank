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
}