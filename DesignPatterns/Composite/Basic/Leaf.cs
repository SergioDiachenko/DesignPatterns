using System;

namespace DesignPatterns.Composite.Basic
{
    class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {

        }
        public override void Add(Component item)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);
        }

        public override void Remove(Component item)
        {
            throw new NotImplementedException();
        }
    }
}
