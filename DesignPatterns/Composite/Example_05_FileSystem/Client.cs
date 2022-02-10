using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatterns.Composite.Example_05_FileSystem
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

            var p1f1 = new FileItem("p1f1.txt", 2100);
            var p1f2 = new FileItem("p1f2.txt", 3100);
            proj1.Add(p1f1);
            proj1.Add(p1f2);

            var p1f3 = new FileItem("p1f3.txt", 4100);
            var p1f4 = new FileItem("p1f4.txt", 5100);
            var subDir1 = new DirectoryItem("sub-dir1");
            subDir1.Add(p1f3);
            subDir1.Add(p1f4);
            proj1.Add(subDir1);

            var p2f1 = new FileItem("p2f1.txt", 6100);
            var p2f2 = new FileItem("p2f2.txt", 7100);
            proj2.Add(p2f1);
            proj2.Add(p2f2);

            Console.WriteLine($"Size proj2: {proj2.GetSizeInKb()}");
            Console.WriteLine($"Size proj1: {proj1.GetSizeInKb()}");
            Console.WriteLine($"Size subDir1: {subDir1.GetSizeInKb()}");
            Console.WriteLine($"Size root: {root.GetSizeInKb()}");

            var items = new List<FileSystemItem>
            {
                root, proj1, proj2, p1f1, p1f2, p1f3, p1f4, subDir1, p2f1, p2f2
            };

            foreach (var item in items)
            {
                Console.WriteLine($"{item.Name} has children: { item.Items.Any() }");
            }
        }
    }
}
