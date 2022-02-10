using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite.Alternative
{
    class Composite : Component
    {
        List<Component> items = new List<Component>();

        public Composite(string name) : base(name)
        {
        }

        public void Add(Component item)
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

        public void Remove(Component item)
        {
            items.Remove(item);
        }

        public override bool HasChildren()
        {
            return items.Any();
        }
    }
}
