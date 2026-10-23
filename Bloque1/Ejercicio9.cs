namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio09
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 9: SALARIO SEMANAL ---");

            double horasTrabajadas = -1;
            while (horasTrabajadas < 0)
            {
                Console.Write("Ingrese las horas trabajadas en la semana: ");
                if (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas < 0)
                {
                    Console.WriteLine("Horas inválidas.");
                }
            }

            decimal tarifaHora = -1;
            while (tarifaHora <= 0)
            {
                Console.Write("Ingrese la tarifa por hora (L.): ");
                if (!decimal.TryParse(Console.ReadLine(), out tarifaHora) || tarifaHora <= 0)
                {
                    Console.WriteLine("Tarifa inválida.");
                }
            }

            double horasNormales = horasTrabajadas > 44 ? 44 : horasTrabajadas;
            double horasExtras = horasTrabajadas > 44 ? horasTrabajadas - 44 : 0;

            decimal salarioNormal = (decimal)horasNormales * tarifaHora;
            decimal salarioExtra = (decimal)horasExtras * (tarifaHora * 1.5m);
            decimal salarioTotal = salarioNormal + salarioExtra;

            Console.WriteLine("\n========================================");
            Console.WriteLine("          DESGLOSE DE SALARIO           ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Horas normales ({horasNormales} hrs): {salarioNormal:C2}");
            Console.WriteLine($"Horas extras ({horasExtras} hrs a 150%): {salarioExtra:C2}");
            Console.WriteLine($"SALARIO TOTAL: {salarioTotal:C2}");
            Console.WriteLine("========================================");
        }
    }
}