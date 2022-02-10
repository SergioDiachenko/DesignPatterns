using System;

namespace DesignPatterns.Mediator._02_Alternative
{
    public class Colleague2 : Colleague
    {
        public override void HandleNotification(string message)
        {
            Console.WriteLine($"Colleague2 receives notification message: {message}");
        }
    }
}
