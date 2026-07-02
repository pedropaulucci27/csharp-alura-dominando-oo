class BancoDeDados : IArmazenavel
{
    private string _dados;

    public void Salvar(string dados)
    {
        _dados = dados;
        Console.WriteLine($"Salvando dados no banco de dados: {dados}");
    }

    public string Recuperar()
    {
        Console.WriteLine("Recuperando dados do banco de dados...");
        return _dados;
    }
}
