public class Calculadora
{
    public static double Calcular(double num1, double num2, char operacao)
    {
        switch (operacao)
        {
            case '+':
                return Soma(num1, num2);
            case '-':
                return Subtracao(num1, num2);
            case '/':
                return Divisao(num1, num2);
            case '*':
                return Multiplicacao(num1, num2);
            case '^':
                return Potencia(num1, num2);
            case 'r':
                return RaizQuadrada(num1);
            default:
                Console.WriteLine("Operação inválida.");
                return 0;
        }
    }

    private static double Soma(double a, double b) => a + b;
    private static double Subtracao(double a, double b) => a - b;
    private static double Multiplicacao(double a, double b) => a * b;

    private static double Divisao(double a, double b)
    {
        if (b != 0)
            return a / b;
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }
    }

    private static double Potencia(double a, double b) => Math.Pow(a, b);
    private static double RaizQuadrada(double a) => Math.Sqrt(a);
}
