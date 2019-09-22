using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            tree.Add(3);
            tree.Add(1);
            tree.Add(5);

            Console.WriteLine(tree.Head.Value);
        }
    }
}
