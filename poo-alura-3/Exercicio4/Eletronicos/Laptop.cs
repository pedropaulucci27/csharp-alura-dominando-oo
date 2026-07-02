class Laptop : AparelhoEletronico
{
    public double TamanhoTela { get; set; }
    public string SistemaOperacional { get; set; }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Tamanho da tela: {TamanhoTela}");
        Console.WriteLine($"Sistema operacional: {SistemaOperacional}");
    }
}
