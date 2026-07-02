public class Cliente
{
    public Cliente(string nome, string contato, Veiculo veiculo)
    {
        Nome = nome;
        Veiculo = veiculo;
        Contato = contato;
    }

    public string Nome { get; set; }
    public Veiculo Veiculo { get; set; }
    public string Contato { get; set; }
}
