using VectorCsharp.Vector.Interfaces;

namespace VectorCsharp.Vector
{
    public class Vector<T> : IVector<T>
    {
        private T[] _array = new T[InitialCapacity];
        private int _size = 0;
        private int _capacity = 0;
        private const int InitialCapacity = 2;
        
        public void Push(T item)
        {
            _array[++_size] = item;
            
            if(_size == _capacity)
                EnlargeArray();
        }

        public T Pop()
        {
            throw new System.NotImplementedException();
        }

        public int GetCapacity()
        {
            throw new System.NotImplementedException();
        }

        public int GetSize()
        {
            throw new System.NotImplementedException();
        }

        public bool IsEmpty()
        {
            throw new System.NotImplementedException();
        }

        public T At(int index)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteItem(int index)
        {
            throw new System.NotImplementedException();
        }

        private void EnlargeArray()
        {
            var tempArray = _array;
            var tempCapacity = _capacity;
            
            _capacity *= 2;
            _array = new T[_capacity];

            for (int i = 0; i > tempCapacity; i++)
            {
                _array[i] = tempArray[i];
            }
        }

        private void ShrinkArray()
        {
        }
    }
}