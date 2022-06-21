using Factory.Factory_Pattern.Animals;
using Factory.Factory_Pattern.Animals.Interface;

namespace Factory.Factory_Pattern;

public class ConcreteFactory : IAnimalFactory
{
    private List<IAnimal> animals = new List<IAnimal>();

    public ConcreteFactory()
    {
        animals.Add(new Duck());
        animals.Add(new Tiger());
        animals.Add(new Duck());
        animals.Add(new Duck());
        animals.Add(new Duck());
        animals.Add(new Duck());
        animals.Add(new Tiger());
    }

    public List<IAnimal> GetAnimalList()
    {
        return animals.ToList();
    }

    public IEnumerable<object> GetDuckList()
    {
        return animals.Where(x => x != null && x.GetType().Name == "Duck");
    }

    public IEnumerable<object> GetTigerList()
    {
        return animals.Where(x => x != null && x.GetType().Name == "Tiger");
    }
}
