
namespace EjercicioAbstracción
{
    public abstract class Matematicas
    {
        public double numero1;
        public double numero2;

        public abstract double Modulo();
        public abstract double Potencia();
        public abstract double RaizCuadrada();
        public abstract double Exponente();

        public void Imprimir()
        {
            Console.WriteLine($"Módulo es: {Modulo()}");
            Console.WriteLine($"Potencia es: {Potencia()}");
            Console.WriteLine($"Raíz Cuadrada es: {RaizCuadrada()}");
            Console.WriteLine($"Exponente es: {Exponente()}");

        }

    }
}