using System;

namespace DesignPatterns.Mediator._01_Basic
{
    public class Colleague2 : Colleague
    {
        public Colleague2(Mediator mediator) : base(mediator)
        {
        }

        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 receives notification message: {message}");
        }
    }
}
