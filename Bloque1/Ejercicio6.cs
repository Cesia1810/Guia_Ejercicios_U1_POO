namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio06
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 6: SUMA DE DÍGITOS ---");

            int numero = 0;
            while (numero < 100 || numero > 999)
            {
                Console.Write("Ingrese un número entero positivo de tres dígitos (100 a 999): ");
                if (!int.TryParse(Console.ReadLine(), out numero) || numero < 100 || numero > 999)
                {
                    Console.WriteLine("Número inválido. Debe tener exactamente 3 dígitos.");
                }
            }

            int centena = numero / 100;
            int decena = (numero / 10) % 10;
            int unidad = numero % 10;
            int suma = centena + decena + unidad;

            Console.WriteLine($"\nDígitos extraídos: {centena}, {decena}, {unidad}");
            Console.WriteLine($"La suma de los dígitos es: {suma}");
        }
    }
}