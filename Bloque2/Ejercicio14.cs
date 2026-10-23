namespace Ejercicios_POO.Bloque2
{
    public class Ejercicio14
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 14: CALCULADORA CON SWITCH ---");
            
            double num1 = LeerDouble("Ingrese el primer número: ");
            double num2 = LeerDouble("Ingrese el segundo número: ");

            Console.WriteLine("Seleccione la operación (+, -, *, /, %): ");
            string? operador = Console.ReadLine();

            switch (operador)
            {
                case "+":
                    Console.WriteLine($"Resultado: {num1} + {num2} = {num1 + num2:F2}");
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {num1} - {num2} = {num1 - num2:F2}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {num1} * {num2} = {num1 * num2:F2}");
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: ¡No se puede dividir entre cero!");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {num1} / {num2} = {num1 / num2:F2}");
                    }
                    break;
                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: ¡No se puede calcular el módulo entre cero!");
                    }
                    else
                    {
                        Console.WriteLine($"Resultado: {num1} % {num2} = {num1 % num2:F2}");
                    }
                    break;
                default:
                    Console.WriteLine("Operador no válido.");
                    break;
            }
        }

        private static double LeerDouble(string mensaje)
        {
            double valor;
            while (true)
            {
                Console.Write(mensaje);
                if (double.TryParse(Console.ReadLine(), out valor))
                {
                    return valor;
                }
                Console.WriteLine("Valor inválido. Intente de nuevo.");
            }
        }
    }
}