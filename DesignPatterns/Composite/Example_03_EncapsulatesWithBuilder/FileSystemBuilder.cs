using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Composite.Example_03_EncapsulatesWithBuilder
{
    public class FileSystemBuilder
    {
        public FileSystemBuilder(string rootDirectory)
        {
            this.Root = new DirectoryItem(rootDirectory);
            this.currentDirectory = this.Root;
        }

        public DirectoryItem Root { get; }

        private DirectoryItem currentDirectory;

        public DirectoryItem AddDirectory(string name)
        {
            var dir = new DirectoryItem(name);
            this.currentDirectory.Add(dir);
            this.currentDirectory = dir;
            return dir;
        }

        public FileItem AddFile(string name, long fileBytes) 
        {
            var file = new FileItem(name, fileBytes);
            this.currentDirectory.Add(file);
            return file;
        }

        public DirectoryItem SetCurrentDirectory(string directoryName)
        {
            var dirStack = new Stack<DirectoryItem>();
            dirStack.Push(this.Root);

            while (dirStack.Any())
            {
                var current = dirStack.Pop();
                if (current.Name == directoryName)
                {
                    this.currentDirectory = current;
                    return current;
                }
                foreach (var item in current.Items.OfType<DirectoryItem>())
                {
                    dirStack.Push(item);
                }
            }

            throw new InvalidOperationException($"Directory name '{directoryName}' not found");
        }
    }

}
