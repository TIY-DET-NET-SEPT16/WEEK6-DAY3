using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[4];

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = i * i;

            Console.WriteLine(GetArrayAtIndex(myArray, 6));

            Console.ReadLine();
        }

        static int GetArrayAtIndex(int[] arry, int index)
        {
            //try
            //{
            string temp3 = "t";

            //int temp2 = Convert.ToInt32(temp3);
            int t = int.MaxValue - 1;
            int temp = t + 100;

            List<string> t2 = null;

            string t4 = t2[0];

            return arry[index];
            //}
            //catch (IndexOutOfRangeException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    return 100;
            //}
            //catch (TypeInitializationException) { }
            //catch (StackOverflowException) { }
            //catch (OverflowException) { }
            //catch (OutOfMemoryException) { }
            //catch (NullReferenceException) { }
            //catch (InvalidCastException) { }
            //catch (DivideByZeroException) { }
            //catch (ArithmeticException) { }
            //catch (ArrayTypeMismatchException) { }
            //catch (SystemException ex2)
            //{
            //    Console.WriteLine(ex2.Message);
            //    return 100;
            //}
            //catch (Exception ex3)
            //{
            //    Console.WriteLine(ex3.Message);
            //    return 100;
        }
    }
}
