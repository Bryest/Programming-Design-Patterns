using AbstractFactory.Product.Interface;

namespace AbstractFactory.Factories
{
    public interface IAbstractFactory
    {
        IProductA CreateProductA();
        IProductB CreateProductB();
    }
}