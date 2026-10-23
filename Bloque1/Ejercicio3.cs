namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio03
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 3: INTERCAMBIO DE VALORES ---");

            int a = 15;
            int b = 42;

            Console.WriteLine($"Valores iniciales: A = {a}, B = {b}");

            // Intercambio con variable temporal
            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"\nDespués del intercambio (con variable temporal):");
            Console.WriteLine($"A = {a}, B = {b}");

            // Reto adicional: intercambio con operaciones aritméticas
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"\nDespués del reto (operaciones aritméticas sin variable temporal):");
            Console.WriteLine($"A = {a}, B = {b}");
        }
    }
}