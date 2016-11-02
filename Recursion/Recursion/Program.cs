using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> filePaths = new List<string>();
            FindAllFilesOfType("C:\\InClassW6D3", filePaths, ".");

            foreach(string s in filePaths)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();
        }

        static void FindAllFilesOfType(string path, List<string>paths, string extension)
        {
            DirectoryInfo di = new DirectoryInfo(path);

            FileInfo[] files = di.GetFiles();

            foreach (FileInfo file in files)
            {
                // if (file.Extension == extension)
                paths.Add(file.FullName);
            }

            DirectoryInfo[] dirs = di.GetDirectories();

            foreach (DirectoryInfo item in dirs)
            {
                FindAllFilesOfType(item.FullName, paths, extension);
            }
        }
    }
}
