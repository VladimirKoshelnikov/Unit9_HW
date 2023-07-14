using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkUnit9
{
    class SortLogicException:Exception{    
        
        public SortLogicException(){
            }
        
        public SortLogicException(string message):base(message){

            }
        }
}