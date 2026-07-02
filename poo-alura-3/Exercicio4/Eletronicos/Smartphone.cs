class Smartphone : AparelhoEletronico
{
    public string Operadora { get; set; }
    public int NumeroDeChips { get; set; }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Operadora: {Operadora}");
        Console.WriteLine($"Número de chips: {NumeroDeChips}");
    }
}
