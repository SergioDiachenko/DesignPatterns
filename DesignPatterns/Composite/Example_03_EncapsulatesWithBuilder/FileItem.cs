namespace DesignPatterns.Composite.Example_03_EncapsulatesWithBuilder
{
    public class FileItem : FileSystemItem
    {
        public FileItem(string name, long fileBytes) : base(name)
        {
            FileBytes = fileBytes;
        }

        public long FileBytes { get; }

        public override decimal GetSizeInKb()
        {
            return decimal.Divide(this.FileBytes, 1000);
        }
    }

}
