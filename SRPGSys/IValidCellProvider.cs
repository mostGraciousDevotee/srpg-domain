using Entity;

namespace SRPGSys
{
    public interface IValidCellProvider
    {
        List<Vector2Int> GetValidCells(Vector2Int startPos, int range);
    }
}