namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio05
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 5: CONVERSIÓN DE TEMPERATURA ---");
            Console.WriteLine("1. Celsius a Fahrenheit");
            Console.WriteLine("2. Celsius a Kelvin");
            Console.WriteLine("3. Fahrenheit a Celsius");
            Console.WriteLine("4. Kelvin a Celsius");
            Console.Write("Seleccione una opción (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                Console.Write("Ingrese la temperatura: ");
                if (double.TryParse(Console.ReadLine(), out double temp))
                {
                    double resultado = 0;
                    switch (opcion)
                    {
                        case 1:
                            resultado = (temp * 9 / 5) + 32;
                            Console.WriteLine($"{temp}°C equivalen a {resultado:F2}°F");
                            break;
                        case 2:
                            resultado = temp + 273.15;
                            Console.WriteLine($"{temp}°C equivalen a {resultado:F2} K");
                            break;
                        case 3:
                            resultado = (temp - 32) * 5 / 9;
                            Console.WriteLine($"{temp}°F equivalen a {resultado:F2}°C");
                            break;
                        case 4:
                            resultado = temp - 273.15;
                            Console.WriteLine($"{temp} K equivalen a {resultado:F2}°C");
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Temperatura inválida.");
                }
            }
            else
            {
                Console.WriteLine("Opción inválida.");
            }
        }
    }
}