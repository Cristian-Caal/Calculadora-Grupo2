using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Bienvenido a la Calculadora");
        Console.WriteLine("1. Suma");
        Console.WriteLine("2. Resta");
        Console.WriteLine("3. Multiplicación");
        Console.WriteLine("4. División");
        Console.Write("Seleccione una opción: ");

        int opcion = int.Parse(Console.ReadLine());
        // TODO: Implementar la lógica de menú
    }

    // TODO: Implementar funciones de suma, resta, multiplicación, división

    public void Restas()
    {
        Console.Writeline("Calculadora de restas");
        Console.WriteLine("Ingrese primer valor");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese segundo valor");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int resultado = a-b;
        Console.Writeline($"El resultado es: {resultado}");
    }
}

