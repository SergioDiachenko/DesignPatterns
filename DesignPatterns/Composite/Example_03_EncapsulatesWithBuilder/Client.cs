using Newtonsoft.Json;
using System;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace DesignPatterns.Composite.Example_03_EncapsulatesWithBuilder
{
    public class Client : IClient
    {
        public void Execute()
        {
            var builder = new FileSystemBuilder("development");
            builder.AddDirectory("project1");
            builder.AddFile("p1f1.txt", 2100);
            builder.AddFile("p1f2.txt", 3100);
            builder.AddDirectory("sub-dir1");
            builder.AddFile("p1f3.txt", 4100);
            builder.AddFile("p1f4.txt", 5100);
            builder.SetCurrentDirectory("development");
            builder.AddDirectory("project2");
            builder.AddFile("p2f1.txt", 6100);
            builder.AddFile("p2f2.txt", 7100);

            Console.WriteLine($"Total size (root): {builder.Root.GetSizeInKb()}");
            //Console.WriteLine(JsonSerializer.Serialize(builder.Root, 
            //    new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine(JsonConvert.SerializeObject(builder.Root, Formatting.Indented));
        }
    }
}
