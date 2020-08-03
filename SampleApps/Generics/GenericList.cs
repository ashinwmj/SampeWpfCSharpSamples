using System;

namespace Generics
{
    public class GenericList<T>
    {
        public void Add(T item)
        {
            throw new NotImplementedException();
        }

        public T this[int index] => throw new NotImplementedException();
    }
}