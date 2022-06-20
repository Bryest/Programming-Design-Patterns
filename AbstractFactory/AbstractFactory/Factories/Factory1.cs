using AbstractFactory.Product;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Factories
{
    public class Factory1 : IAbstractFactory
    {
        public IProductA CreateProductA()
        {
            return new ProductA();
        }

        public IProductB CreateProductB()
        {
            return new ProductB();
        }
    }
}