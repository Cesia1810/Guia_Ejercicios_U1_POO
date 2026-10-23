namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio10
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 10: PRÉSTAMO SIMPLE ---");

            decimal monto = -1;
            while (monto <= 0)
            {
                Console.Write("Ingrese el monto del préstamo (L.): ");
                if (!decimal.TryParse(Console.ReadLine(), out monto) || monto <= 0)
                {
                    Console.WriteLine("Monto inválido.");
                }
            }

            decimal tasaInteresAnual = -1;
            while (tasaInteresAnual <= 0)
            {
                Console.Write("Ingrese la tasa de interés anual (%): ");
                if (!decimal.TryParse(Console.ReadLine(), out tasaInteresAnual) || tasaInteresAnual <= 0)
                {
                    Console.WriteLine("Tasa inválida.");
                }
            }

            int plazoMeses = -1;
            while (plazoMeses <= 0)
            {
                Console.Write("Ingrese el plazo en meses (> 0): ");
                if (!int.TryParse(Console.ReadLine(), out plazoMeses) || plazoMeses <= 0)
                {
                    Console.WriteLine("Plazo inválido.");
                }
            }

            decimal tiempoEnAnios = (decimal)plazoMeses / 12m;
            decimal interesTotal = monto * (tasaInteresAnual / 100m) * tiempoEnAnios;
            decimal totalPagar = monto + interesTotal;
            decimal cuotaMensual = totalPagar / plazoMeses;

            Console.WriteLine("\n========================================");
            Console.WriteLine("         RESUMEN DEL PRÉSTAMO           ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Monto solicitado: {monto:C2}");
            Console.WriteLine($"Interés total a pagar: {interesTotal:C2}");
            Console.WriteLine($"Total a reembolsar: {totalPagar:C2}");
            Console.WriteLine($"Cuota mensual fija: {cuotaMensual:C2}");
            Console.WriteLine("========================================");
        }
    }
}