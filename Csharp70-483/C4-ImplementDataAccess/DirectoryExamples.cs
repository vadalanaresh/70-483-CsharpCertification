using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C4_ImplementDataAccess
{
    public class DirectoryExamples
    {
        public void CreateDirectoryUsingDirectoryInfo()
        {
            var path = @"c:\Naresh\CsharpTemp";
            var directoryInfo = new DirectoryInfo(path);
            directoryInfo.Create();

        }
    }
}
