public class Triangulo : FormaGeometrica
{
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Lado1 { get; set; }
    public double Lado2 { get; set; } // corrigido: PascalCase
    public double Lado3 { get; set; } // corrigido: PascalCase

    public override double CalcularArea()
    {
        return Base * Altura / 2;
    }

    public override double CalcularPerimetro()
    {
        return Lado1 + Lado2 + Lado3; // corrigido: PascalCase
    }
}
