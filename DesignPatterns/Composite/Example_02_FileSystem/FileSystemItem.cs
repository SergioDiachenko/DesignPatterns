namespace DesignPatterns.Composite.Example_02_FileSystem
{
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
