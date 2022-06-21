namespace Builder.Builder_Pattern;

public class ConcreteBuilder : IBuilderHouse
{
    private Product _product = new Product();

    public Product GetProduct()
    {
        return this._product;
    }

    public void Reset()
    {
        this._product = new Product();
    }
    public void BuildDoor()
    {
        this._product.Add("Puerta");
    }

    public void BuildWindow()
    {
        this._product.Add("Window");
    }

    public void BuildLeavingRoom()
    {
        this._product.Add("LeavingRoom");
    }

    public void BuildKitchen()
    {
        this._product.Add("Kitchen");
    }
}
