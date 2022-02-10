using System.Text;

namespace DesignPatterns.Composite.Alternative
{
    abstract class Component
    {
        public Component(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public abstract void Display(int depth);
        public abstract bool HasChildren();
    }
}
