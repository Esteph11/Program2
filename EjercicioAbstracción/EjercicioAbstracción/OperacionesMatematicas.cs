
namespace EjercicioAbstracción
{
    public class OperacionesMatematicas : Matematicas
    {
        public OperacionesMatematicas(double num1, double num2) : base(num1, num2) { }

        public double Modulo()
        {
            return numero1 % numero2;
        }

        public double Potencia()
        {
            return Math.Pow(numero1, numero2);
        }

        public double RaizCuadrada()
        {
            return Math.Sqrt(numero1);
        }

        public double Exponente()
        {
            return Math.Exp(numero1);
        }
        public void Imprimir()
        {
            Console.WriteLine($"Módulo: {Modulo()}");
            Console.WriteLine($"Potencia (numero1^numero2: {Potencia()}");
            Console.WriteLine($"Raíz Cuadrada: {RaizCuadrada()}");
            Console.WriteLine($"Exponente de numero1 (e^numero1): {Exponente()}");
        }
    }
}