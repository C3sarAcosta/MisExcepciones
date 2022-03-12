using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MisExcepciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Program MyObject = new Program();
                MyObject.ThrowException();
                Console.ReadKey();
            }
            catch(MyException CaughtException)
            {
                Console.WriteLine(CaughtException.Message);
                Console.ReadKey();
            }
        }

        public void ThrowException()
        {
            //Iniciamos nuestras propias excepciones con throw
            throw new MyException();
        }
    }

    class MyException : ApplicationException
    {
        public MyException() : base("This is my exception message")
        {

        }
    }
}
