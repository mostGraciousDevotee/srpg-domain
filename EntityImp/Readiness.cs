using Entity;

namespace EntityImp
{
    public class ReadinessComponent : IReadiness
    {
        const int ReadinessPoint = 100;
        
        int _speed;
        int _readiness;
        public ReadinessComponent(int speed)
        {
            _speed = speed;
        }
        
        public int Speed => _speed;

        public int Readiness => _readiness;

        public void UpdateReadiness()
        {
            _readiness += _speed;
        }

        public void Reset()
        {
            _readiness -= ReadinessPoint;
            _readiness = _readiness < 0 ? 0 : _readiness;
        }
    }
}