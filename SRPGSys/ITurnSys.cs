using Entity;

namespace SRPGSys
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