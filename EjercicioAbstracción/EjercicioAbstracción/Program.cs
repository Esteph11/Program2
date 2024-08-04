namespace EjercicioAbstracción;

class Program
{
    static void Main(string[] args)
    {
        OperacionesMatematicas operacionesMatematicas = new OperacionesMatematicas();

        Console.WriteLine("Ingrese el primer número:");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        double numero2 = Convert.ToDouble(Console.ReadLine());
       
        operacionesMatematicas.Imprimir();

        Console.ReadLine();
        Console.WriteLine("Presione cualquier tecla para salir.");
        Console.ReadLine();
    }
}


