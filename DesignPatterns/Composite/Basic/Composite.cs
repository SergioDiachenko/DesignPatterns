using System;
using System.Collections.Generic;

namespace DesignPatterns.Composite.Basic
{
    class Composite : Component
    {
        List<Component> items = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component item)
        {
            items.Add(item);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + this.Name);

            foreach (var item in items)
            {
                item.Display(depth + 2);
            }
        }

        public override void Remove(Component item)
        {
            items.Remove(item);
        }
    }
}
