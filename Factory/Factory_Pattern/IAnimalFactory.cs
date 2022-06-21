using Factory.Factory_Pattern.Animals.Interface;

namespace Factory.Factory_Pattern;

public interface IAnimalFactory
{
    public List<IAnimal> GetAnimalList();
    public IEnumerable<object> GetDuckList();
    public IEnumerable<object> GetTigerList();
}
