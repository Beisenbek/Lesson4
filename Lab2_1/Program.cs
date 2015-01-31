using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(Environment.SystemDirectory);
            //ShowDirectory(dir);
            FSW();
        }


        static void ShowDirectory(DirectoryInfo dirInfo)
        {
            var x = dirInfo.GetFiles();

            for (int i = 0; i < x.Length; ++i)
            {
                Console.WriteLine(x[i].FullName);
            }
        }
        static FileSystemWatcher fsw = new FileSystemWatcher(@"C:\Users\bsnbk2\Desktop");
            
        static void FSW()
        {
            fsw.EnableRaisingEvents = true;
            fsw.NotifyFilter = NotifyFilters.Size;
            

            fsw.Changed += fsw_Changed;
            fsw.WaitForChanged(WatcherChangeTypes.Changed);
        }

        static void fsw_Changed(object sender, FileSystemEventArgs e)
        {

            try
            {
                Console.WriteLine("Somthing changed!");
            }
            finally
            {
                fsw.EnableRaisingEvents = false;
            }
        }
    }
}
