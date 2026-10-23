namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio07
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 7: TIEMPO TRANSCURRIDO ---");

            Console.WriteLine("--- Hora Inicial ---");
            int h1 = LeerValor("Hora (0-23): ", 0, 23);
            int m1 = LeerValor("Minutos (0-59): ", 0, 59);
            int s1 = LeerValor("Segundos (0-59): ", 0, 59);

            Console.WriteLine("\n--- Hora Final ---");
            int h2 = LeerValor("Hora (0-23): ", 0, 23);
            int m2 = LeerValor("Minutos (0-59): ", 0, 59);
            int s2 = LeerValor("Segundos (0-59): ", 0, 59);

            int totalSegundos1 = (h1 * 3600) + (m1 * 60) + s1;
            int totalSegundos2 = (h2 * 3600) + (m2 * 60) + s2;
            int diferenciaSegundos = totalSegundos2 - totalSegundos1;

            if (diferenciaSegundos < 0)
            {
                diferenciaSegundos += 24 * 3600;
            }

            int horasDiferencia = diferenciaSegundos / 3600;
            int minutosDiferencia = (diferenciaSegundos % 3600) / 60;
            int segundosDiferencia = diferenciaSegundos % 60;

            Console.WriteLine("\n========================================");
            Console.WriteLine($"Diferencia: {horasDiferencia}h {minutosDiferencia}m {segundosDiferencia}s");
            Console.WriteLine("========================================");
        }

        private static int LeerValor(string mensaje, int min, int max)
        {
            int val = -1;
            while (val < min || val > max)
            {
                Console.Write(mensaje);
                if (!int.TryParse(Console.ReadLine(), out val) || val < min || val > max)
                {
                    Console.WriteLine($"Valor fuera de rango ({min}-{max}).");
                }
            }
            return val;
        }
    }
}