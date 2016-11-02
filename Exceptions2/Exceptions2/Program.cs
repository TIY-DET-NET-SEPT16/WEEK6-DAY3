using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions2
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> employees = new List<string>();

            //ReadTheFile(employees);

            //All the code to populate the Employees list

            //Add New employees...

            WriteEmployeeListtoFile();
        }

        static void ReadTheFile(List<string> employees)
        {
            FileStream file = null;
            FileInfo fileInfo = null;

            try
            {
                fileInfo = new FileInfo("C:\\file.txt");

                file = fileInfo.OpenRead();

                Console.ReadLine();
            }
            catch (UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                //if (file != null)
                //{
                file.Close();
                //}
            }

        }

        static void WriteEmployeeListtoFile()
        {
            FileStream file = null;
            FileInfo fileInfo = null;

            try
            {
                fileInfo = new FileInfo("C:\\temp\\file.txt");

                file = fileInfo.OpenRead();
                fileInfo.OpenWrite();

                Console.ReadLine();
            }
            catch(UnauthorizedAccessException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }
    }
}
