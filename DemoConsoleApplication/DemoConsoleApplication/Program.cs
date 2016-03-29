using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in new[] { 1, 2, 3, 4 })
            {
                Console.WriteLine(item);
            }
        }
    }
}
