
using EjercicioAbstracción;

    Console.WriteLine("Ingrese el primer número:");
    double numero1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número:");
    double numero2 = Convert.ToDouble(Console.ReadLine());

    OperacionesMatematicas operacionesMatematicas = new OperacionesMatematicas(numero1, numero2);
    operacionesMatematicas.Imprimir();
    Console.WriteLine();
    Console.WriteLine("Presione cualquier tecla para salir.");
    Console.ReadLine();

