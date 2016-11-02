using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 5;
            try
            {
                if (t == 5)
                {
                    MyException ex = new MyException("My Custom Exception was thrown");
                    throw ex;
                }

                Exception ex2 = new Exception();
                throw ex2;
            }
            catch (MyException e)
            {
                Console.WriteLine("The custom exception was thrown");
            }
            catch (Exception e2)
            {
                Console.WriteLine("The exception was thrown");
            }

            Console.WriteLine(t);
        }
    }

    class MyException : Exception
    {
        public MyException(string message)
        {

        }
    }
}
