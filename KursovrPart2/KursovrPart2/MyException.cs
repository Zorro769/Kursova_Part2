using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovrPart2
{
    public class MyException : Exception
    {
        private readonly string message;

        public MyException(string message)
        {
            this.message = message;
        }
        ~MyException() { }

        public string ShowException()
        {
            return message; 
        }
    }
}
