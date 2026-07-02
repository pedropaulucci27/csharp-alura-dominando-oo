class Servico : IPagavel
{
    public string Nome { get; set; }
    public double TaxaHoraria { get; set; }
    public double HorasTrabalhadas { get; set; }

    public double CalcularPagamento()
    {
        return TaxaHoraria * HorasTrabalhadas;
    }
}
