using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator._02_Alternative
{
    public class Client : IClient
    {
        public void Execute()
        {
            var mediator = new ConcreteMediator();
            //var c1 = new Colleague1();
            //var c2 = new Colleague2();

            //mediator.Register(c1);
            //mediator.Register(c2);

            var c1 = mediator.CreateColleague<Colleague1>();
            var c2 = mediator.CreateColleague<Colleague2>();

            c1.Send("Hello, World! (from c1)");
            c2.Send("hi, there! (from c2)");
        }
    }
}
