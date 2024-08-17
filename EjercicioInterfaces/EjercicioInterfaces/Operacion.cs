
namespace EjercicioInterfaces
{
    public class Operacion : IOperaciones
    {
        public double baseRectangulo;
        public double alturaRectangulo;
        public double baseTriangulo;
        public double alturaTriangulo;
        public double radio;
        public double lado;
        public double radioCircunferencia;

        public void IniciarCalculos(double baseRectangulo, double alturaRectangulo, double baseTriangulo, double alturaTriangulo, double radio, double lado, double radioCircunferencia)
        {
            this.baseRectangulo = baseRectangulo;
            this.alturaRectangulo = alturaRectangulo;
            this.baseTriangulo = baseTriangulo;
            this.alturaTriangulo = alturaTriangulo;
            this.radio = radio;
            this.lado = lado;
            this.radioCircunferencia = radioCircunferencia;
        }

        public double AreaRectangulo()
        {
            return baseRectangulo * alturaRectangulo;
        }
        public double AreaTriangulo()
        {
            return (baseTriangulo * alturaTriangulo) / 2;
        }
        public double AreaCirculo()
        {
            return Math.PI * radio * radio;
        }
        public double VolumenCubo()
        {
            return lado * lado * lado;
        }
        public double LongitudCircunferencia()
        {
            return 2 * Math.PI * radioCircunferencia;
        }

        public void Imprimir()
        {
            Console.WriteLine("Operaciones de calcular el área realizadas:");
            Console.WriteLine($"Area Rectangulo es: {AreaRectangulo()}");
            Console.WriteLine($"Area Triangulo es: {AreaTriangulo()}");
            Console.WriteLine($"Area Circulo es: {AreaCirculo()}");
            Console.WriteLine($"Volumen Cubo es: {VolumenCubo()}");
            Console.WriteLine($"Longitud Circunferencia es: {LongitudCircunferencia()}");
        }
    }
}
