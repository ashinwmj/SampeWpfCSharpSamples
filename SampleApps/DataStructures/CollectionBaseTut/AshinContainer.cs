using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.CollectionBaseTut
{
    public class AshinContainer:CollectionBase
    {
        public void Add(object item)
        {
            InnerList.Add(item);
        }
        public void Remove(object item)
        {
            InnerList.Remove(item);
        }

        public new void Clear()
        {
            InnerList.Clear();

        }
    }
}
