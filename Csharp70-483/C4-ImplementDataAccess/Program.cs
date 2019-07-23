using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C4_ImplementDataAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            var drive = new Drives();
            drive.PrintDriveInfo();
            Console.Read();
        }
    }
}
