using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Mediator._02_Alternative
{
    public class ConcreteMediator : Mediator
    {
        private List<Colleague> colleagues = new List<Colleague>();

        public void Register(Colleague colleague)
        {
            colleague.SetMediator(this);
            this.colleagues.Add(colleague);
        }

        public T CreateColleague<T>() where T : Colleague, new()
        {
            var c = new T();
            c.SetMediator(this);
            this.colleagues.Add(c);
            return c;
        }

        public override void Send(string message, Colleague colleague)
        {
            colleagues.Where(_ => _ != colleague).ToList().ForEach(_ => _.HandleNotification(message));
        }
    }
}
