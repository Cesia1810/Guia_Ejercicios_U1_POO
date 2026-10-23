using Ejercicios_POO.Bloque1;

namespace Ejercicios_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            while (opcion != 11)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("     MENÚ BLOQUE 1: VARIABLES Y OPERADORES ");
                Console.WriteLine("========================================");
                Console.WriteLine("1. Conversor de moneda");
                Console.WriteLine("2. Calculadora de IMC");
                Console.WriteLine("3. Intercambio de valores");
                Console.WriteLine("4. Área y perímetro");
                Console.WriteLine("5. Conversión de temperatura");
                Console.WriteLine("6. Suma de dígitos");
                Console.WriteLine("7. Tiempo transcurrido");
                Console.WriteLine("8. Desglose de billetes");
                Console.WriteLine("9. Cálculo de salario semanal");
                Console.WriteLine("10. Calculadora de préstamo simple");
                Console.WriteLine("11. Salir");
                Console.Write("Seleccione una opción (1-11): ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                {
                    switch (opcion)
                    {
                        case 1: Ejercicio01.Ejecutar(); break;
                        case 2: Ejercicio02.Ejecutar(); break;
                        case 3: Ejercicio03.Ejecutar(); break;
                        case 4: Ejercicio04.Ejecutar(); break;
                        case 5: Ejercicio05.Ejecutar(); break;
                        case 6: Ejercicio06.Ejecutar(); break;
                        case 7: Ejercicio07.Ejecutar(); break;
                        case 8: Ejercicio08.Ejecutar(); break;
                        case 9: Ejercicio09.Ejecutar(); break;
                        case 10: Ejercicio10.Ejecutar(); break;
                        case 11: Console.WriteLine("Saliendo..."); break;
                        default: Console.WriteLine("Opción no válida."); break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }

                if (opcion != 11)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}