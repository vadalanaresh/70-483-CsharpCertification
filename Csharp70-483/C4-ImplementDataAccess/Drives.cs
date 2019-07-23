using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C4_ImplementDataAccess
{
    /// <summary>
    /// Works with Drives related stuff
    /// </summary>
    public class Drives
    {
        /// <summary>
        /// Gets all the drives info and prints
        /// </summary>
        public void PrintDriveInfo()
        {
            var drivesInfo = DriveInfo.GetDrives();
            foreach (var driveInfo in drivesInfo)
            {
                Console.WriteLine($"Drive {driveInfo.Name}");
                Console.WriteLine($"Drive type {driveInfo.DriveType}");
                if (driveInfo.IsReady)
                {
                    Console.WriteLine($"Volume label {driveInfo.VolumeLabel}");
                    Console.WriteLine($"Drive format {driveInfo.DriveFormat}");
                    Console.WriteLine($"Available free space {driveInfo.AvailableFreeSpace}");
                    Console.WriteLine($"Total free space {driveInfo.TotalFreeSpace}");
                    Console.WriteLine($"Total size of drive {driveInfo.TotalSize}");
                }
            }
        }
    }
}
