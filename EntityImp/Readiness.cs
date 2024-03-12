using Entity;

namespace EntityImp
{
    public class Readiness : IReadiness
    {
        int _speed;
        int _readiness;
        public Readiness(int speed, int readiness)
        {
            _speed = speed;
            _readiness = readiness;
        }
        
        public int Speed => _speed;

        int IReadiness.Readiness => _readiness;
    }
}