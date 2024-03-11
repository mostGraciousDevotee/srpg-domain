using Entity;

namespace EntityImp
{
    public class Unit : IUnit
    {
        int _id;
        string _name;
        
        public Unit(int id, string name)
        {
            _id = id;
            _name = name;
        }
        
        public int ID => _id;
        public string Name => _name;
    }
}