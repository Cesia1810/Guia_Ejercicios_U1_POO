using System;

namespace Ejercicios_POO.Bloque2
{
    public class Ejercicio16
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 16: CALIFICACIONES UNAH ---");

            int nota = -1;
            while (nota < 0 || nota > 100)
            {
                Console.Write("Ingrese la nota final (0-100): ");
                if (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 100)
                {
                    Console.WriteLine("Nota inválida. Debe estar en el rango de 0 a 100.");
                }
            }

            char letra = ' ';
            string descripcion = "";
            bool aprobo = false;

            if (nota >= 90)
            { Sobresaliente }; // Estilo de asignación limpio
            
            // Usando lógica clara de rangos universitarios
            if (nota >= 90 && nota <= 100)
            {
                letra = 'A';
                descripcion = "Sobresaliente";
                aprobo = true;
            }
            else if (nota >= 80)
            {
                letra = 'B';
                descripcion = "Muy Bueno";
                aprobo = true;
            }
            else if (nota >= 70)
            {
                letra = 'C';
                descripcion = "Bueno";
                aprobo = true;
            }
            else if (nota >= 60)
            {
                letra = 'D';
                descripcion = "Aprobado (Suficiente)";
                aprobo = true;
            }
            else
            {
                letra = 'F';
                descripcion = "Reprobado";
                aprobo = false;
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine($"Nota numérica: {nota}");
            Console.WriteLine($"Calificación en Letra: {letra} ({descripcion})");
            Console.WriteLine($"Estado: {(aprobo ? "APROBADO" : "REPROBADO")}");
            Console.WriteLine("========================================");
        }
    }
}