using Entity;

namespace SRPGSys
{
    public interface ITurnSys
    {
        IUnit Current {get; }

        void AddUnit(IUnit unit);
        void Start();
        void End();
    }
}