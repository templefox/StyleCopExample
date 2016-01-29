using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri uri = new Uri("file:///C:/Program Files/ThisIsMyAddIn/ThisIsMyAddin.vsto|vstolocal");
            Console.WriteLine(uri.ToString());
            Console.Read();
        }
    }
}
