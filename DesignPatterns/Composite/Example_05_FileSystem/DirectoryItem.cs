using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite.Example_05_FileSystem
{
    public class DirectoryItem : FileSystemItem
    {
        public DirectoryItem(string name) : base(name)
        {
        }

        public void Add(FileSystemItem item)
        {
            Items.Add(item);
        }

        public void Remove(FileSystemItem item)
        {
            Items.Remove(item);
        }

        public override decimal GetSizeInKb()
        {
            return this.Items.Sum(x => x.GetSizeInKb());
        }
    }

}
