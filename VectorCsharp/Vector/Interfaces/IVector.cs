namespace VectorCsharp.Vector.Interfaces
{
    public interface IVector<T>
    {
        void Push(T item);
        T Pop();
        int GetCapacity();
        int GetSize();
        bool IsEmpty();
        T At(int index);
        void DeleteItem(int index);
    }
}