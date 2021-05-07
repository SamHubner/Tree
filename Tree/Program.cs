using System;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Tree t = new Tree();
            t.Add(2);
            t.Add(6);
            t.Add(1);
            t.Add(8);
            t.Add(7);

            t.traverse1();
        }
    }
}
