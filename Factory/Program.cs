// See https://aka.ms/new-console-template for more information
using Factory.Factory_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        ConcreteFactory factory = new ConcreteFactory();

        Console.WriteLine(factory.GetAnimalList().Count());
        Console.WriteLine("Ducks");
        Console.WriteLine(factory.GetDuckList().Count());
        Console.WriteLine("Tiger");
        Console.WriteLine(factory.GetTigerList().Count());
    }
}