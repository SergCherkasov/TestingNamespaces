using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestingNamespaces.Add;

namespace TestingNamespaces.UI
{
    public class ui
    {
        TestingNamespaces.Add.Add add = new TestingNamespaces.Add.Add();

        public void Run()
        {
            Console.WriteLine("Enter the nubers to ADD:");
            Console.WriteLine();
            Console.WriteLine("Enter X:");
            int x =Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y:");
            int y = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
            int result = add.Adding(x, y);
            Console.WriteLine($"Result of your expression:{result}");
        }

    }
}
