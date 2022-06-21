//https://refactoring.guru/es/design-patterns/builder/csharp/example
using Builder.Builder_Pattern;

var director = new Director();
var builder = new ConcreteBuilder();

director.BuilderHouse = builder;
Console.WriteLine("Minimal Product");
director.BuildMinimalViableProduct();
Console.WriteLine(builder.GetProduct().ListParts());

builder.Reset();

Console.WriteLine("Full Product");
director.BuildFullProduct();
Console.WriteLine(builder.GetProduct().ListParts());
