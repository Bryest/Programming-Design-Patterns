using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product
{
    public class ProductB : IProductB
    {
        public string UsefulFunctionB()
        {
            return "Useful Product B";
        }
    }
}