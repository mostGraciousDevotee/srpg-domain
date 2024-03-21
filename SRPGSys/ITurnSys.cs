using Entity;

namespace TurnSystemImp
{
    public interface ITurnSys
    {
        event Action<int, string> UnitActive;
        
        IUnit? Current {get; }

        void AddUnit(IUnit unit);
        void Start();
        void End();
    }
}