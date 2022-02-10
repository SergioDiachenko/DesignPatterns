using System.Diagnostics;

namespace DesignPatterns.Composite.Example_03_EncapsulatesWithBuilder
{
    [DebuggerDisplay("Name: {Name}")]
    public abstract class FileSystemItem
    {
        public FileSystemItem(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public abstract decimal GetSizeInKb();
    }
}
