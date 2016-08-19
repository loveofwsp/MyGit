using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyGit
{
    using System.Diagnostics;

    class Program
    {
        static void Main(string[] args)
        {
            DebuggableAttribute.DebuggingModes;
            Console.WriteLine("world");
            DebuggableAttribute.DebuggingModes;
        }
    }
}
