using System;

namespace Generics
{
    public class BookList // need to created specific list implementation based on datatype
    {
        public void Add(Book book)
        {
            //
        }

        public Book this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}