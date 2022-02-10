using System;

namespace DesignPatterns.Composite.Alternative
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }

        public override bool HasChildren()
        {
            return false;
        }
    }
}
