
namespace EjercicioAbstracción
{
    public class OperacionesMatematicas : Matematicas
    {
  
        public override double Modulo()
        {
            return numero1 % numero2;
        }

        public override double Potencia()
        {
            return Math.Pow(numero1, numero2);
        }

        public override double RaizCuadrada()
        {
            return Math.Sqrt(numero1);
        }

        public override double Exponente()
        {
            return Math.Exp(numero1);
        }

    }
}