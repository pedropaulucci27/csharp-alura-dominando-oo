class Tablet : AparelhoEletronico
{
    public double TamanhoTela { get; set; }

    public override void ExibirInformacoes()
    {
        base.ExibirInformacoes();
        Console.WriteLine($"Tamanho da tela: {TamanhoTela}");
    }
}
