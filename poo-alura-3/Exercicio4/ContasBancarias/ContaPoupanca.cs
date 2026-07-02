internal class ContaPoupanca : ContaBancaria
{
    public double TaxaRendimento { get; set; }

    public override double CalcularSaldo()
    {
        return Saldo * (1 + TaxaRendimento);
    }
}
