using System;

namespace DesignPatterns.Mediator._03_Example
{
    public class Tester : TeamMember
    {
        public Tester(string name) : base(name)
        {
        }

        public override void Receive(string from, string message)
        {
            Console.WriteLine($"{this.Name} ({nameof(Tester)}) has received: ");
            base.Receive(from, message);
        }
    }
}
