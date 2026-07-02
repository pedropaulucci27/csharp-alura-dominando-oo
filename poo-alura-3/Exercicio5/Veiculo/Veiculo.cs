class Veiculo : IPilotavel, IVoavel
{
    public string Nome { get; set; }

    public void Pilotar()
    {
        Console.WriteLine($"Pilotando o veículo {Nome}");
    }

    public void Voar()
    {
        Console.WriteLine($"O veículo {Nome} está voando");
    }
}
