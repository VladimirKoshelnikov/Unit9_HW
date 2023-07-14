using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace HomeworkUnit9
{
    public delegate void ArrayWorkDelegate(List<string> array);
    public class ArraySortLogic
    { 
        SortLogicException sortLogicException = new SortLogicException("The array sort mode is chosen wrong");
        event ArrayWorkDelegate SortArrayEvent;
        public void StartArraySort(int mode, List<string> stringArray)
        {
            List<string> sortedArray = new List<string>();
            Console.WriteLine("Процесс начат!");
            if (mode == 1){
                SortArrayEvent = SortArray;
            } 
            else if (mode == 2) {
                SortArrayEvent = SortArrayByDescending;
            }
            else {
                throw sortLogicException;
            }

            SortArrayEvent?.Invoke(stringArray);
        }
        private void SortArray(List<string> array){
            array.Sort();
        }
        private void SortArrayByDescending(List<string> array){
            array.Sort();
            array.Reverse();
        }
    }
}