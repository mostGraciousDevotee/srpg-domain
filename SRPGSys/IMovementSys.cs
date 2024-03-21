using Entity;

namespace MovementSystem
{
    public interface IMovementSys
    {
        event Action<List<Vector2Int>>? MovementDisplayed;
        void DisplayMovement();
    }
}