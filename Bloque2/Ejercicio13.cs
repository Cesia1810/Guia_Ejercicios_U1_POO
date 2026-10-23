namespace Ejercicios_POO.Bloque2
{
    public class Ejercicio13
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 13: DÍA DE LA SEMANA ---");
            Console.Write("Ingrese un número del 1 al 7: ");

            if (int.TryParse(Console.ReadLine(), out int dia))
            {
                // 1. Usando switch clásico
                string nombreDiaClasico = "";
                switch (dia)
                {
                    case 1: nombreDiaClasico = "Lunes"; break;
                    case 2: nombreDiaClasico = "Martes"; break;
                    case 3: nombreDiaClasico = "Miércoles"; break;
                    case 4: nombreDiaClasico = "Jueves"; break;
                    case 5: nombreDiaClasico = "Viernes"; break;
                    case 6: nombreDiaClasico = "Sábado"; break;
                    case 7: nombreDiaClasico = "Domingo"; break;
                    default: nombreDiaClasico = "Día inválido"; break;
                }

                // 2. Usando expresión switch (requisito de la guía)
                string nombreDiaExpresion = dia switch
                {
                    1 => "Lunes",
                    2 => "Martes",
                    3 => "Miércoles",
                    4 => "Jueves",
                    5 => "Viernes",
                    6 => "Sábado",
                    7 => "Domingo",
                    _ => "Día inválido"
                };

                Console.WriteLine($"\nResultado con switch clásico: {nombreDiaClasico}");
                Console.WriteLine($"Resultado con expresión switch: {nombreDiaExpresion}");
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }
}