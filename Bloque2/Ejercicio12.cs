namespace Ejercicios_POO.Bloque2
{
    public class Ejercicio12
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 12: MAYOR DE TRES NÚMEROS ---");

            int n1 = LeerEntero("Ingrese el primer número: ");
            int n2 = LeerEntero("Ingrese el segundo número: ");
            int n3 = LeerEntero("Ingrese el tercer número: ");

            // Encontrar el mayor usando operadores lógicos (&&)
            int mayor;
            if (n1 >= n2 && n1 >= n3)
            {
                mayor = n1;
            }
            else if (n2 >= n1 && n2 >= n3)
            {
                mayor = n2;
            }
            else
            {
                mayor = n3;
            }

            // Encontrar el menor
            int menor;
            if (n1 <= n2 && n1 <= n3)
            {
                menor = n1;
            }
            else if (n2 <= n1 && n2 <= n3)
            {
                menor = n2;
            }
            else
            {
                menor = n3;
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine($"El número mayor es: {mayor}");
            Console.WriteLine($"El número menor es: {menor}");
            Console.WriteLine("========================================");
        }

        private static int LeerEntero(string mensaje)
        {
            int valor;
            while (true)
            {
                Console.Write(mensaje);
                if (int.TryParse(Console.ReadLine(), out valor))
                {
                    return valor;
                }
                Console.WriteLine("Número inválido. Intente de nuevo.");
            }
        }
    }
}