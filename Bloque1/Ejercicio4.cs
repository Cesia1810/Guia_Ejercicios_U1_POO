namespace Ejercicios_POO.Bloque1
{
    public class Ejercicio04
    {
        public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("--- EJERCICIO 4: ÁREA Y PERÍMETRO ---");
            Console.WriteLine("1. Círculo");
            Console.WriteLine("2. Triángulo");
            Console.WriteLine("3. Rectángulo");
            Console.WriteLine("4. Trapecio");
            Console.Write("Seleccione una figura (1-4): ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        double radio = LeerPositivo("Ingrese el radio del círculo: ");
                        double areaCirculo = Math.PI * radio * radio;
                        double perimetroCirculo = 2 * Math.PI * radio;
                        Console.WriteLine($"Área: {areaCirculo:F2} | Perímetro: {perimetroCirculo:F2}");
                        break;

                    case 2:
                        double bTri = LeerPositivo("Ingrese la base del triángulo: ");
                        double hTri = LeerPositivo("Ingrese la altura del triángulo: ");
                        double l1 = LeerPositivo("Ingrese el lado 1: ");
                        double l2 = LeerPositivo("Ingrese el lado 2: ");
                        double l3 = LeerPositivo("Ingrese el lado 3: ");
                        Console.WriteLine($"Área: {(bTri * hTri) / 2:F2} | Perímetro: {l1 + l2 + l3:F2}");
                        break;

                    case 3:
                        double bRec = LeerPositivo("Ingrese la base del rectángulo: ");
                        double hRec = LeerPositivo("Ingrese la altura del rectángulo: ");
                        Console.WriteLine($"Área: {bRec * hRec:F2} | Perímetro: {2 * (bRec + hRec):F2}");
                        break;

                    case 4:
                        double bMayor = LeerPositivo("Ingrese la base mayor: ");
                        double bMenor = LeerPositivo("Ingrese la base menor: ");
                        double hTrap = LeerPositivo("Ingrese la altura: ");
                        double lad1 = LeerPositivo("Ingrese lado lateral 1: ");
                        double lad2 = LeerPositivo("Ingrese lado lateral 2: ");
                        double areaTrap = ((bMayor + bMenor) * hTrap) / 2;
                        double perTrap = bMayor + bMenor + lad1 + lad2;
                        Console.WriteLine($"Área: {areaTrap:F2} | Perímetro: {perTrap:F2}");
                        break;

                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }

        private static double LeerPositivo(string mensaje)
        {
            double valor = -1;
            while (valor <= 0)
            {
                Console.Write(mensaje);
                if (!double.TryParse(Console.ReadLine(), out valor) || valor <= 0)
                {
                    Console.WriteLine("El valor debe ser un número positivo mayor a cero.");
                }
            }
            return valor;
        }
    }
}