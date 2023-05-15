using bytebank;
var contaDoAndre = new ContaCorrente
{
    agencia = 15,
    conta = "1010-X",
    titular = "André Silva",
    saldo = 100,
};

Console.WriteLine($"O saldo da conta corrente do André é de R$ {contaDoAndre.saldo}.");