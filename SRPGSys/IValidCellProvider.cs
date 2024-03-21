using Entity;

namespace CellSystem
{
    public interface IValidCellProvider
    {
        List<Vector2Int> GetValidCells(Vector2Int startPos, int range);
    }
}