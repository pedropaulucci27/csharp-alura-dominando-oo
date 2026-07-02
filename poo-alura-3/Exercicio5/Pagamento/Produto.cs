class Produto : IPagavel
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public int Quantidade { get; set; }

    public double CalcularPagamento()
    {
        return Preco * Quantidade;
    }
}
