namespace Entity
{
    public struct Position : IEquatable<Position>
    {
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        public readonly int x;
        public readonly int y;

        public static bool operator ==(Position a, Position b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(Position a, Position b)
        {
            return !(a == b);
        }

        public bool Equals(Position other)
        {
            return this == other;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Position)
            {
                return this == (Position)obj;
            }
            
            return false;
        }

        public override int GetHashCode()
        {
            return x.GetHashCode() ^ y.GetHashCode();
        }
    }
}