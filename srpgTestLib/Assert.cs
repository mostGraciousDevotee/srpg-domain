namespace Test
{
    public static class Assert
    {
        public static bool AreEqual<T>(T expected, T result, string errorMessage) where T : IEquatable<T>
        {
            if (!expected.Equals(result))
            {
                Console.Error.WriteLine(errorMessage);
                return false;
            }

            return true;
        }

        public static bool AreEqualRef<T>(T expected, T result, string errorMessage)
        {
            if (!ReferenceEquals(expected, result))
            {
                Console.Error.WriteLine(errorMessage);
                return false;
            }

            return true;
        }
    }
}