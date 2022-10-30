using System;
using System.Collections.Generic;
namespace BuildingLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new LinkedList();
            list.addLast(10);
            list.addLast(20);
            list.addLast(30);
            // list.removeFirst();
            list.addFirst(40);
            // System.Console.WriteLine(list.indexOf(40));
            // System.Console.WriteLine((list.contains(10)));
            // list.removeLast();
            list.printAllNodes();
        }
    }    
}
