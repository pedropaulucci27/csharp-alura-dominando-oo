public class Mecanico
{
    public List<Veiculo> Veiculos { get; set; }
    public string Nome { get; set; }

    public Mecanico(string nome)
    {
        Veiculos = new List<Veiculo>();
        Nome = nome;
    }
}
