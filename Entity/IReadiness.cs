namespace Entity
{
    public interface IReadiness : IComponent
    {
        int Speed {get; }
        int Readiness {get; }

        void UpdateReadiness();
        void Reset();
    }
}