using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Xml.Linq;

namespace DesignPatterns.Composite.Example_04_XElement
{
    public class Client : IClient
    {
        public void Execute()
        {
            string path = Path.Combine(Path.GetDirectoryName(
                Assembly.GetExecutingAssembly().Location),
                @"Composite\Example_04_XElement\file-system.xml");

            var xml = XElement.Load(path);

            foreach (var leaf in xml.FindElements(x => !x.HasElements))
            {
                Console.WriteLine($"***** LEAF: {leaf.Attribute("name")}, " +
                    $"{leaf.Attribute("fileBytes")}");
            }
        }
    }
}
