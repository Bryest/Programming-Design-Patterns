namespace Builder.Builder_Pattern;

public class Director
{
    private IBuilderHouse _builderHouse;
    public IBuilderHouse BuilderHouse
    {
        set
        {
            _builderHouse = value;
        }
    }
    public void BuildMinimalViableProduct()
    {
        this._builderHouse.BuildDoor();
    }

    public void BuildFullProduct()
    {
        this._builderHouse.BuildDoor();
        this._builderHouse.BuildKitchen();
        this._builderHouse.BuildLeavingRoom();
        this._builderHouse.BuildWindow();
    }

}
