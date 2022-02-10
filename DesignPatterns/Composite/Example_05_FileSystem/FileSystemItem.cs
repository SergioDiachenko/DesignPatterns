using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite.Example_05_FileSystem
{
    public abstract class FileSystemItem
    {
        public FileSystemItem(string name)
        {
            Name = name;
        }

        public string Name { get; }

        public List<FileSystemItem> Items { get; } = new List<FileSystemItem>();

        public abstract decimal GetSizeInKb();
    }

}
