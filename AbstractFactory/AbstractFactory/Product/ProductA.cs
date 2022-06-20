using AbstractFactory.Factories;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product
{
    public class ProductA : IProductA
    {
        public string UsefulFunctionA()
        {
            return "Useful Product A";
        }
    }
}