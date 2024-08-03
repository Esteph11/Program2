using EjercicioAbstracción;
public abstract class Matematicas
{
    public Matematicas(double numero1, double numero2)
    {
        
        OperacionesMatematicas operacionesMatematicas = new OperacionesMatematicas(numero1, numero2);

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el primer número:");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo número:");
            double numero2 = Convert.ToDouble(Console.ReadLine());


            Console.ReadLine(); 
        }
    }
}

