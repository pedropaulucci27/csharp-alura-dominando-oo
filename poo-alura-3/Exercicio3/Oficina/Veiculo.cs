public class Veiculo
{
    public Veiculo(string marca, Mecanico mecanico, string ano)
    {
        Marca = marca;
        Mecanico = mecanico;
        Ano = ano;
    }

    public string Marca { get; set; }
    public Mecanico Mecanico { get; set; }
    public string Ano { get; set; }
}
