﻿using System;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMapNode<string, string> mapNode = new MyMapNode<string, string>(5);
            Console.WriteLine("Adding KeyValue pair");
            mapNode.Add("0", "to");
            mapNode.Add("1", "be");
            mapNode.Add("2", "or");
            mapNode.Add("3", "to");
            mapNode.Add("4", "be");
            mapNode.Add("5", "not");

            Console.WriteLine("getting the value of index 1=" + mapNode.Get("1"));

            Console.WriteLine("getting the value of index 5=" + mapNode.Get("5"));

            Console.WriteLine("Removing");
            mapNode.Remove("4");
            //Console.WriteLine("getting value " + mapNode.Get("4"));

            Console.WriteLine("Displaying");
            mapNode.Display();
            
            Console.ReadLine();
        }
    }
}
