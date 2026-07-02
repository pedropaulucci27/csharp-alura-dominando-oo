class AparelhoEletronico
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public string Marca { get; set; }

    public virtual void ExibirInformacoes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: {Preco}");
        Console.WriteLine($"Marca: {Marca}");
    }
}
