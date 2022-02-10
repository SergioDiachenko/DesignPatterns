using System.Text;

namespace DesignPatterns.Composite.Basic
{
    abstract class Component
    {
        public Component(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract void Add(Component item);

        public abstract void Remove(Component item);

        public abstract void Display(int depth);
    }
 }
