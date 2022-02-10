using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Mediator._02_Alternative
{
    public abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }
}
