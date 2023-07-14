using System;
using System.IO;
using System.Collections.Generic;

namespace HomeworkUnit9{
    class Task2{
        
        /*
        Создайте консольное приложение, в котором будет происходить сортировка списка фамилий из пяти человек. 
       
        Сортировка происходит при введении пользователем либо: 
        - числа 1 (сортировка А-Я), 
        - либо числа 2 (сортировка Я-А).

        Дополнительно реализуйте проверку введённых данных от пользователя через конструкцию 
        TryCatchFinally с использованием собственного типа исключения.
        */

        static void Main(){
            SortLogicException sortLogicException = new SortLogicException();
            ArraySortLogic arraySortLogic = new ArraySortLogic();

            List<string> ArraySecondName = new List<string>(); 
            ArraySecondName.Add("Съешев-Еще");
            ArraySecondName.Add("Этих-Мягких"); 
            ArraySecondName.Add("Французских-Булкин");
            ArraySecondName.Add("И-выпьев");
            ArraySecondName.Add("Чай-У");

            Console.WriteLine("Исходный массив:");
            foreach(string item in ArraySecondName){
                Console.WriteLine(item);
            }
            Console.WriteLine();
            
            Console.WriteLine("Введите режим работы алгоритма: \n1 - Сортировка  от А до Я\n2 - Сортировка  от Я до А");
            try {
                int mode = int.Parse(Console.ReadLine());
                arraySortLogic.StartArraySort(mode,ArraySecondName);
            }
            catch (Exception ex){
                Console.WriteLine(ex.Message);
            }
            
            Console.WriteLine();
            Console.WriteLine("Отсортированный массив:");
            foreach(string item in ArraySecondName){
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}