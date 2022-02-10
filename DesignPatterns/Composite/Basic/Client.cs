using System;

namespace DesignPatterns.Composite.Basic
{
    class Client : IClient
    {
        public void Execute()
        {
            var root = new Composite("Root");
            root.Add(new Leaf("File A"));
            root.Add(new Leaf("File B"));

            var dirc1 = new Composite("Directory C1");
            dirc1.Add(new Leaf("File C1-A"));
            dirc1.Add(new Leaf("File C1-B"));

            var dirc2 = new Composite("Directory C2");
            dirc2.Add(new Leaf("File C2-A"));
            dirc1.Add(dirc2);

            root.Add(dirc1);
            root.Add(new Leaf("File D"));

            root.Display(1);
        }
    }
}
