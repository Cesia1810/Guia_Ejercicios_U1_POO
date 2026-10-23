namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio02
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 2: CALCULADORA DE IMC ---");

            double peso = -1;
            while (peso <= 0)
            {
                Console.Write("Ingrese su peso en kg (> 0): ");
                if (!double.TryParse(Console.ReadLine(), out peso) || peso <= 0)
                {
                    Console.WriteLine("Peso inválido. Debe ser mayor que cero.");
                }
            }

            double altura = -1;
            while (altura <= 0)
            {
                Console.Write("Ingrese su altura en metros (ej. 1.75): ");
                if (!double.TryParse(Console.ReadLine(), out altura) || altura <= 0)
                {
                    Console.WriteLine("Altura inválida. Debe ser mayor que cero.");
                }
            }

            double imc = peso / (altura * altura);
            string categoria = "";

            if (imc < 18.5)
            {
                categoria = "Bajo peso";
            }
            else if (imc < 25.0)
            {
                categoria = "Normal";
            }
            else if (imc < 30.0)
            {
                categoria = "Sobrepeso";
            }
            else
            {
                categoria = "Obesidad";
            }

            Console.WriteLine("\n========================================");
            Console.WriteLine("           RESULTADO DE IMC             ");
            Console.WriteLine("========================================");
            Console.WriteLine($"Su IMC es: {imc:F2}");
            Console.WriteLine($"Categoría: {categoria}");
            Console.WriteLine("========================================");
        }
    }
}