namespace Entity
{
    public interface IUnit
    {
        int ID {get; }
        string Name {get; }
        void AddComponent<T>(T component) where T : IComponent;
        T GetComponent<T>() where T : IComponent;
    }
}
