using System;
using System.Collections.Generic;

namespace DataStructures
{
    public class BinaryTree<T> : Tree<T>
    {
        public override bool Compare(T node, T compareNode)
        {
            return EqualityComparer<T>.Default.Equals(node, compareNode);
        }
    }
}
