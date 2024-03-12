using Entity;

namespace EntityImp
{
    public class Unit : IUnit
    {
        int _id;
        string _name;
        Dictionary<Type, IComponent> _components = new Dictionary<Type, IComponent>();
        
        public Unit(int id, string name)
        {
            _id = id;
            _name = name;
        }
        
        public int ID => _id;
        public string Name => _name;

        public void AddComponent<T>(T component) where T : IComponent
        {
            _components[typeof(T)] = component;
        }

        public T GetComponent<T>() where T : IComponent
        {
            if (_components.TryGetValue(typeof(T), out IComponent? component))
            {
                return (T)component;
            }
            else
            {
                return default(T)!;
            }
        }
    }
}