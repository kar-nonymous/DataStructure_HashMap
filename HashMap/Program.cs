using System;

namespace HashMap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyMapNode<string, string> mapNode = new MyMapNode<string, string>(5);
            Console.WriteLine("Adding KeyValue pair");
            mapNode.Add("0", "paranoids");
            mapNode.Add("1", "are");
            mapNode.Add("2", "not");
            mapNode.Add("3", "paranoid");
            mapNode.Add("4", "because");
            mapNode.Add("5", "they");
            mapNode.Add("5", "are");
            mapNode.Add("5", "paranoid");
            mapNode.Add("5", "but");
            mapNode.Add("5", "because");
            mapNode.Add("5", "they");
            mapNode.Add("5", "keep");
            mapNode.Add("5", "putting");
            mapNode.Add("5", "themselves");
            mapNode.Add("5", "deliberately");
            mapNode.Add("5", "into");
            mapNode.Add("5", "paranoid");
            mapNode.Add("5", "avoidable");
            mapNode.Add("5", "situations");

            Console.WriteLine("Displaying");
            mapNode.Display();

            Console.WriteLine("Frequency.....");
            Console.WriteLine(mapNode.FindFrequency("paranoid"));

            mapNode.RemoveData("avoidable");
            mapNode.Display();
        }
    }
}
