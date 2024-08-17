using EjercicioInterfaces;

Operacion operacionesA = new Operacion();

        Console.WriteLine("Calcular el área de un rectángulo");
        Console.Write("Ingrese la base: ");
        double baseRectangulo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura: ");
        double alturaRectangulo = Convert.ToDouble(Console.ReadLine());
        double areaRectangulo = operacionesA.AreaRectangulo();
        Console.WriteLine($"Área del rectángulo: {areaRectangulo}");
        Console.WriteLine();

        Console.WriteLine("Calcular el área de un triángulo");
        Console.Write("Ingrese la base: ");
        double baseTriangulo = Convert.ToDouble(Console.ReadLine());
        Console.Write("Ingrese la altura: ");
        double alturaTriangulo = Convert.ToDouble(Console.ReadLine());
        double areaTriangulo = operacionesA.AreaTriangulo();
        Console.WriteLine($"Área del triángulo: {areaTriangulo}");
        Console.WriteLine();

        Console.WriteLine("Calcular el área de un círculo");
        Console.Write("Ingrese el radio: ");
        double radio = Convert.ToDouble(Console.ReadLine());
        double areaCirculo = operacionesA.AreaCirculo();
        Console.WriteLine($"Área del círculo: {areaCirculo}");
        Console.WriteLine();

        Console.WriteLine("Calcular el volumen de un cubo");
        Console.Write("Ingrese el lado: ");
        double lado = Convert.ToDouble(Console.ReadLine());
        double volumenCubo = operacionesA.VolumenCubo();
        Console.WriteLine($"Volumen del cubo: {volumenCubo}");
        Console.WriteLine();

        Console.WriteLine("Calcular la longitud de la circunferencia");
        Console.Write("Ingrese el radio: ");
        double radioCircunferencia = Convert.ToDouble(Console.ReadLine());
        double longitudCircunferencia = operacionesA.LongitudCircunferencia();
        Console.WriteLine($"Longitud de la circunferencia: {longitudCircunferencia}");
        Console.WriteLine();

operacionesA.IniciarCalculos(5, 10, 4, 8, 3, 2, 1);
operacionesA.Imprimir();
Console.ReadLine();


