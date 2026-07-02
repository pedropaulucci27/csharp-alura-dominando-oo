internal class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2); // corrigido: adicionado return
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * Raio;
    }
}
