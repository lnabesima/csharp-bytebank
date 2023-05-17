namespace MelhorPreco;

public class Delivery
{
    public int numeroPedido;
    public Cliente cliente;
    public ItemPedido itemPedido;
    public float precoPedido;
}

public class Cliente
{
    public string nome;
    public string cpf;
    public string email;
    public Endereco enderecoEntrega;
}

public class Endereco
{
    public string logradouro;
    public int numero;
    public string cep;
}

public class ItemPedido
{
    public int numeroPedido;
    public Produto produto1;
    public Produto produto2;
    public Produto produto3;
    public int quantidadePedida;
}

public class Produto
{
    public int codigoProduto;
    public string descricaoProduto;
    public double precoProduto;
}