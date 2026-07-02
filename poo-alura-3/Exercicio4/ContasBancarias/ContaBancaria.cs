abstract class ContaBancaria
{
    public string Titular { get; set; }
    public double Saldo { get; set; }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }

    public virtual void Sacar(double valor)
    {
        if (valor <= Saldo)
            Saldo -= valor;
        else
            Console.WriteLine("Saldo insuficiente.");
    }

    public virtual double CalcularSaldo()
    {
        return Saldo;
    }
}
