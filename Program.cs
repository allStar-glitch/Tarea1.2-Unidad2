// See https://aka.ms/new-console-template for more information
public class Program
{
    public static void Main(string[] args)
    {
        Circulo c1 = new Circulo();

        Circulo c2 = new Circulo(10.0);

        Console.WriteLine($"\nCirculo 1, tiene un area de {c1.CalcularArea()} y una circunferencia de {c1.CalcularCircunferencia()}");
        Console.WriteLine($"\nCirculo 2, tiene un area de {c2.CalcularArea()} y una circunferencia de {c2.CalcularCircunferencia()}");

        Console.WriteLine("\n\n\nfin del programa...");
        Console.ReadKey();
    }

}
