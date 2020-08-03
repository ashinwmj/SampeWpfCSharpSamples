using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.Pluralsight
{
    public interface IDoubleLinkList
    {
        public DoubleLinkNode Head { get; set; }
        public DoubleLinkNode Tail { get; set; }

        public int Count { get; set; }

        void AddItemToFirst(DoubleLinkNode node);
        void AddItemToLast(DoubleLinkNode node);
        void RemoveItemFromFirst();
        void RemoveItemFromLast();
    }
    