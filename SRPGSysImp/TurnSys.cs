using Entity;

namespace TurnSystemImp
{
    public class TurnSys : ITurnSys
    {
        const int ReadinessPoint = 100;
        int _processGuard;
        
        IUnit? _currentUnit;
        List<IUnit> _unitList = new List<IUnit>();
        Queue<IUnit> _unitQueue = new Queue<IUnit>();
        
        public event Action<int, string>? UnitActive;
        public IUnit? Current => _currentUnit;

        public void AddUnit(IUnit unit)
        {
            _unitList.Add(unit);
        }

        public void End()
        {
            _currentUnit?.GetComponent<IReadiness>().Reset();
            ProcessUnitTurn();
        }

        public void Start()
        {
            ProcessUnitTurn();
        }

        void ProcessUnitTurn()
        {
            if (UnitInQueue())
            {
                _processGuard = 0;
                _currentUnit = _unitQueue.Dequeue();

                UnitActive?.Invoke(_currentUnit.ID, _currentUnit.Name);
            }
            else
            {
                _processGuard++;
                ProcessGuard();
                UpdateUnitReadiness();
                ProcessUnitTurn();
            }
        }

        bool UnitInQueue()
        {
            return _unitQueue.TryPeek(out IUnit? unit);
        }

        void ProcessGuard()
        {
            if (_processGuard >= 100)
            {
                throw new Exception("TurnSys Process overflow");
            }
        }

        void UpdateUnitReadiness()
        {
            foreach (IUnit unit in _unitList)
            {
                var readinessComponent = unit.GetComponent<IReadiness>();
                readinessComponent.UpdateReadiness();

                if (readinessComponent.Readiness >= ReadinessPoint)
                {
                    Enqueue(unit);
                }
            }
        }

        void Enqueue(IUnit unit)
        {
            _unitQueue.Enqueue(unit);
        }
    }
}