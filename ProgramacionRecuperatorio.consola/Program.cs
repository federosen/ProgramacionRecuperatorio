namespace ProgramacionRecuperatorio.consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadPrismas = 0;
            double basePrisma, alturaPrisma, DistanciaPrisma;

            do
            {

                Console.Write("Ingrese la base del prisma: ");
                while (!double.TryParse(Console.ReadLine(), out basePrisma) || basePrisma < 0)
                {
                    Console.Write("Valor no válido. Ingrese un valor positivo para la base: ");
                }

                if (basePrisma != 0)
                {
                    Console.Write("Ingrese la altura del prisma: ");
                    while (!double.TryParse(Console.ReadLine(), out alturaPrisma) || alturaPrisma < 0)
                    {
                        Console.Write("Valor no válido. Ingrese un valor positivo para la altura: ");
                    }

                    Console.Write("Ingrese la distancia del prisma: ");
                    while (!double.TryParse(Console.ReadLine(), out DistanciaPrisma) || DistanciaPrisma < 0)
                    {
                        Console.Write("Valor no válido. Ingrese un valor positivo para la longitud: ");
                    }

                    double areaBase = CalcularAreaBase(basePrisma, alturaPrisma);
                    double areaLateral = CalcularAreaLateral(DistanciaPrisma, alturaPrisma);
                    double volumen = CalcularVolumen(areaBase, alturaPrisma);
                    double diagonal = CalcularDiagonal(basePrisma, alturaPrisma);

                    Console.WriteLine($"Área Base: {areaBase}");
                    Console.WriteLine($"Área Lateral: {areaLateral}");
                    Console.WriteLine($"Volumen: {volumen}");
                    Console.WriteLine($"Diagonal: {diagonal}");

                    cantidadPrismas++;
                }
            } while (basePrisma != 0);

            Console.WriteLine($"Cantidad de prismas ingresados: {cantidadPrismas}");

        }
        static double CalcularAreaBase(double basePrisma, double alturaPrisma)
        {
            return 2 * (basePrisma * alturaPrisma);
        }

        static double CalcularAreaLateral(double DistanciaPrisma, double alturaPrisma)
        {
            return 3 * (DistanciaPrisma * alturaPrisma);
        }

        static double CalcularVolumen(double areaBase, double alturaPrisma)
        {
            return areaBase * alturaPrisma;
        }

        static double CalcularDiagonal(double basePrisma, double alturaPrisma)
        {
            return Math.Sqrt(Math.Pow(basePrisma, 2) + Math.Pow(alturaPrisma, 2));
        }

    }
}