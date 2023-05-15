using bytebank;
var contaDoAndre = new ContaCorrente
{
    agencia = 15,
    conta = "1010-X",
    titular = "André Silva",
    saldo = 100,
};

Console.WriteLine($"O saldo da conta corrente do André é de R$ {contaDoAndre.saldo}.");
contaDoAndre.Depositar(100);
Console.WriteLine($"O saldo da conta corrente do André é de R$ {contaDoAndre.saldo}.");
contaDoAndre.Sacar(200);
Console.WriteLine($"O saldo da conta corrente do André é de R$ {contaDoAndre.saldo}.");

var contaDaMaria = new ContaCorrente
{
    agencia = 17,
    conta = "1010-5",
    titular = "Maria Souza",
    saldo = 350,

};

contaDoAndre.Transferir(100, contaDaMaria);
Console.WriteLine($"O saldo da conta corrente do André é de R$ {contaDoAndre.saldo}.");
Console.WriteLine($"O saldo da conta corrente da Ana é de R$ {contaDaMaria.saldo}.");

contaDaMaria.MostraInformacoes();