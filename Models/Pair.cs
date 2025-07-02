namespace task.Models
{
    public struct Pair<T1, T2>
    {
        public T1 First;
        public T2 Second;

        public Pair(T1 first, T2 second)
        {
            First = first;
            Second = second;
        }

        public static bool operator ==(Pair<T1, T2> left, Pair<T1, T2> right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Pair<T1, T2> left, Pair<T1, T2> right)
        {
            return !(left == right);
        }
    }
}
