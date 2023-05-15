using bytebank;
var contaDoAndre = new ContaCorrente
{
    agencia = 15,
    conta = "1010-X",
    titular = new Cliente
    {
        cpf = "01234567891",
        nome= "André Silva",
        profissao = "Padeiro"
    },
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
    titular = new Cliente
    {
        nome= "Maria Silva",
        cpf= "98765432100",
        profissao = "Professora"
    },
    saldo = 350,

};

contaDoAndre.Transferir(100, contaDaMaria);
Console.WriteLine($"O saldo da conta corrente do André é de R$ {contaDoAndre.saldo}.");
Console.WriteLine($"O saldo da conta corrente da Ana é de R$ {contaDaMaria.saldo}.");

contaDaMaria.MostraInformacoes();