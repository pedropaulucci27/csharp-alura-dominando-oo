internal class ContaCorrente : ContaBancaria
{
    public double Limite { get; set; }

    public override void Sacar(double valor)
    {
        if (valor <= Saldo + Limite)
            Saldo -= valor;
        else
            Console.WriteLine("Limite insuficiente.");
    }

    public override double CalcularSaldo()
    {
        return Saldo + Limite;
    }
}
