namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio08
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 8: DESGLOSE DE BILLETES ---");

            int monto = -1;
            while (monto <= 0)
            {
                Console.Write("Ingrese un monto entero en lempiras (> 0): ");
                if (!int.TryParse(Console.ReadLine(), out monto) || monto <= 0)
                {
                    Console.WriteLine("Monto inválido. Ingrese un valor mayor que cero.");
                }
            }

            int[] denominaciones = { 500, 100, 50, 20, 10, 5, 2, 1 };
            int restante = monto;

            Console.WriteLine($"\nDesglose para L. {monto}:");
            for (int i = 0; i < denominaciones.Length; i++)
            {
                int cantidad = restante / denominaciones[i];
                if (cantidad > 0)
                {
                    Console.WriteLine($"Billetes de L. {denominaciones[i]}: {cantidad}");
                    restante %= denominaciones[i];
                }
            }
        }
    }
}