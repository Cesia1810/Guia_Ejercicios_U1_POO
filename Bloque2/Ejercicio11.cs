namespace Ejercicios_POO.Bloque2
{
    public class Ejercicio11
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 11: POSITIVO, NEGATIVO O CERO ---");

            int numero = 0;
            bool entradaValida = false;

            while (!entradaValida)
            {
                Console.Write("Ingrese un número entero: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Ingrese un número entero.");
                }
            }

            // Determinamos si es positivo, negativo o cero
            if (numero > 0)
            {
                Console.WriteLine($"El número {numero} es POSITIVO.");
            }
            else if (numero < 0)
            {
                Console.WriteLine($"El número {numero} es NEGATIVO.");
            }
            else
            {
                Console.WriteLine("El número es CERO.");
            }

            // Uso del operador ternario para par o impar
            string paridad = (numero % 2 == 0) ? "par" : "impar";
            Console.WriteLine($"Además, el número es {paridad}.");
        }
    }
}