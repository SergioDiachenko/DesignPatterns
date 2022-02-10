using System;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite.Example_02_FileSystem
{
    public class Client : IClient
    {
        public void Execute()
        {
            var root = new DirectoryItem("development");
            var proj1 = new DirectoryItem("project1");
            var proj2 = new DirectoryItem("project2");
            root.Add(proj1);
            root.Add(proj2);

            proj1.Add(new FileItem("p1f1.txt", 2100));
            proj1.Add(new FileItem("p1f2.txt", 3100));
            var subDir1 = new DirectoryItem("sub-dir1");
            subDir1.Add(new FileItem("p1f3.txt", 4100));
            subDir1.Add(new FileItem("p1f4.txt", 5100));
            proj1.Add(subDir1);

            proj2.Add(new FileItem("p2f1.txt", 6100));
            proj2.Add(new FileItem("p2f2.txt", 7100));

            Console.WriteLine($"Size proj2: {proj2.GetSizeInKb()}");
            Console.WriteLine($"Size proj1: {proj1.GetSizeInKb()}");
            Console.WriteLine($"Size subDir1: {subDir1.GetSizeInKb()}");
            Console.WriteLine($"Size root: {root.GetSizeInKb()}");
        }
    }
}
