using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IClient client;

            // Composite
            //client = new Composite.Basic.Client();
            //client = new Composite.Alternative.Client();
            //client = new Composite.Example_01_FileSystem.Client();
            //client = new Composite.Example_03_EncapsulatesWithBuilder.Client();
            //client = new Composite.Example_04_XElement.Client();
            //client = new Composite.Example_05_FileSystem.Client();
            //client = new Mediator._01_Basic.Client();
            //client = new Mediator._02_Alternative.Client();
            client = new Mediator._03_Example.Client();

            client.Execute();

            Console.ReadKey();
        }
    }
}
