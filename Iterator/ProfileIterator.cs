namespace DesignPatterns.Behavioral.Iterator
{
    public interface ProfileIterator
    {
        Profile GetNext();
        bool HasMore();
    }
}