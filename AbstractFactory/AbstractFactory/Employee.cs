using AbstractFactory.Factories;

namespace AbstractFactory
{
    public class Employee
    {
        public void Main()
        {
            Console.WriteLine("Employee: Product with Factory1");
            EmployeeCreateProducts(new Factory1());

            Console.WriteLine("Employee: Product with Factory2");
            EmployeeCreateProducts(new Factory2());
        }

        public void EmployeeCreateProducts(IAbstractFactory factory)
        {
            var productA = factory.CreateProductA();
            var productB = factory.CreateProductB();
            Console.WriteLine(productA.UsefulFunctionA());
            Console.WriteLine(productB.UsefulFunctionB());
        }
    }
}