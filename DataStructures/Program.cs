using System;
using System.IO;
using System.Reflection;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> tree = new BinaryTree<int>();

            Random random = new Random();

            for (int i = 0; i < 1000000; i++)
            {
                // Stack overflow at the moment
                //tree.Add(random.Next());
            }

            Console.WriteLine(tree.Head.Value); 
        }
    }
}
