class Arquivo : IArmazenavel
{
    private string _dados;

    public void Salvar(string dados)
    {
        _dados = dados;
        Console.WriteLine($"Salvando dados no arquivo: {dados}");
    }

    public string Recuperar()
    {
        Console.WriteLine("Recuperando dados do arquivo...");
        return _dados;
    }
}
