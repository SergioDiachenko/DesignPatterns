namespace DesignPatterns.Composite.Example_01_FileSystem
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
