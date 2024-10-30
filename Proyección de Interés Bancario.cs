// Nombre del estudiante: Nombre Completo
// Grupo: Grupo #
// Programa: Proyección de Interés Bancario
// Código Fuente: autoría propia

using System;

class Program
{
    static void Main()
    {
        // Definición de variables
        double capitalInicial;
        int meses;
        double tasaInteres = 0.007; // 0.7% en decimal
        double[] capitales; // Arreglo para almacenar capital mes a mes

        // Captura de datos
        Console.Write("Ingrese el capital inicial: ");
        capitalInicial = double.Parse(Console.ReadLine());

        Console.Write("Ingrese el número de meses: ");
        meses = int.Parse(Console.ReadLine());

        // Inicialización del arreglo
        capitales = new double[meses];

        // Cálculo del capital mes a mes
        for (int mes = 0; mes < meses; mes++)
        {
            if (mes == 0)
            {
                capitales[mes] = capitalInicial; // Primer mes es el capital inicial
            }
            else
            {
                capitales[mes] = capitales[mes - 1] + (capitales[mes - 1] * tasaInteres); // Interés
            }
        }

        // Mostrar resultados
        Console.WriteLine("\nCapital mes a mes:");
        Console.WriteLine("Mes\tCapital");
        for (int mes = 0; mes < meses; mes++)
        {
            Console.WriteLine($"{mes + 1}\t{capitales[mes]:F2}");
        }

        // Capital final
        Console.WriteLine($"\nEl capital final después de {meses} meses es: {capitales[meses - 1]:F2}");
    }
}
