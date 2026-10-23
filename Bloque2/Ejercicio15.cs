namespace Ejercicios_POO.Bloque2
{
    public class Ejercicio15
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 15: VOCAL O CONSONANTE ---");
            Console.Write("Ingrese una letra: ");

            string? entrada = Console.ReadLine();

            // Validar que se haya ingresado exactamente un caracter y que sea una letra
            if (!string.IsNullOrEmpty(entrada) && entrada.Length == 1 && char.IsLetter(entrada[0]))
            {
                char letra = char.ToLower(entrada[0]);

                switch (letra)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        Console.WriteLine($"La letra '{entrada[0]}' es una VOCAL.");
                        break;
                    default:
                        Console.WriteLine($"La letra '{entrada[0]}' es una CONSONANTE.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Error: Debe ingresar estrictamente una sola letra.");
            }
        }
    }
}