namespace Entity
{
    public struct Vector2Int : IEquatable<Vector2Int>
    {
        public Vector2Int(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public static Vector2Int zero => new Vector2Int(0, 0);
        public static Vector2Int up => new Vector2Int(0, 1);
        public static Vector2Int left => new Vector2Int(-1, 0);
        public static Vector2Int down => new Vector2Int(0, -1);
        public static Vector2Int right => new Vector2Int(1, 0);


        
        public readonly int x;
        public readonly int y;

        public static bool operator ==(Vector2Int a, Vector2Int b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Vector2Int a, Vector2Int b)
        {
            return !(a == b);
        }

        public static Vector2Int operator +(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.x + b.x, a.y + b.y);
        }

        public static Vector2Int operator -(Vector2Int a, Vector2Int b)
        {
            return new Vector2Int(a.x - b.x, a.y - b.y);
        }

        public bool Equals(Vector2Int other)
        {
            return this == other;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Vector2Int)
            {
                return this == (Vector2Int)obj;
            }
            
            return false;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }
    }
}