using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldObf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"{(char)0x48}{(char)0x65}{(char)0x6C}{(char)0x6C}{(char)0x6F}{(char)0x2C}{(char)0x20}{(char)0x57}{(char)0x6F}{(char)0x72}{(char)0x6C}{(char)0x64}{(char)0x21}");
            Console.Read();
        }
    }
}
