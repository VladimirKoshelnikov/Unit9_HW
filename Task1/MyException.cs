using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkUnit9
{
        public class MyException:Exception
        {
        public MyException(){}
        public MyException(string message):base(message){}
        }
    }
