namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio01
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 1: CONVERSOR DE MONEDA ---");

            decimal montoLempiras = -1;
            while (montoLempiras < 0)
            {
                Console.Write("Ingrese el monto en lempiras (L.): ");
                if (!decimal.TryParse(Console.ReadLine(), out montoLempiras) || montoLempiras < 0)
                {
                    Console.WriteLine("Monto inválido. Ingrese un valor mayor o igual a cero.");
                }
            }

            decimal tasaDolar = -1;
            while (tasaDolar <= 0)
            {
                Console.Write("Ingrese la tasa de cambio del día para el Dólar ($): ");
                if (!decimal.TryParse(Console.ReadLine(), out tasaDolar) || tasaDolar <= 0)
                {
                    Console.WriteLine("Tasa inválida. Debe ser mayor que cero.");
                }
            }

            decimal tasaEuro = -1;
            while (tasaEuro <= 0)
            {
                Console.Write("Ingrese la tasa de cambio del día para el Euro (€): ");
                if (!decimal.TryParse(Console.ReadLine(), out tasaEuro) || tasaEuro <= 0)
                {
                    Console.WriteLine("Tasa inválida. Debe ser mayor que cero.");
                }
            }

            decimal dolares = montoLempiras / tasaDolar;
            decimal euros = montoLempiras / tasaEuro;

            Console.WriteLine("\n========================================");
            Console.WriteLine("           RESULTADOS DE CONVERSIÓN      ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Monto inicial en Lempiras: L. {montoLempiras:N2}");
            Console.WriteLine($"Equivalente en Dólares: $ {dolares:N2}");
            Console.WriteLine($"Equivalente en Euros: € {euros:N2}");
            Console.WriteLine("========================================");
        }
    }
}