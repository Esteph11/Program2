
namespace EjercicioAbstracción
{
    public class OperacionesMatematicas : Matematicas
    {
        public OperacionesMatematicas(double numero1, double numero2) : base(numero1, numero2) { }

        public override double Modulo()
        {
            return num1 % num2;
        }

        public override double Potencia()
        {
            return Math.Pow(num1, num2);
        }

        public override double RaizCuadrada()
        {
            return Math.Sqrt(num1);
        }

        public override double Exponente()
        {
            return Math.Exp(num1);
        }

    }
}