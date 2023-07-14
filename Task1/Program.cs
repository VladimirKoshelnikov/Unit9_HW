using System;
using System.IO;

namespace HomeworkUnit9{
    class Task1{
    
        /*
        Задание 1

        Создайте свой тип исключения.
        Сделайте массив из пяти различных видов исключений, включая собственный тип исключения. Реализуйте конструкцию TryCatchFinally, в которой будет итерация на каждый тип исключения (блок finally по желанию).
        В блоке catch выведите в консольном сообщении текст исключения.
        */
        static void Main(){
            
            Exception[] arrayExceptions = {
                new ArgumentException(),
                new ArgumentNullException(),
                new ArgumentOutOfRangeException(),
                new OverflowException(),
                new MyException()
            };

            try{
                throw arrayExceptions[4];
            }
            catch(Exception ex){
                Console.WriteLine($"Сообщение: {ex.Message}");
                if (ex == arrayExceptions[0]){
                    Console.WriteLine("Вызвано исключение arrayExceptions[0]");
                }
                else if (ex == arrayExceptions[1]){
                    Console.WriteLine("Вызвано исключение arrayExceptions[1]");
                }
                else if (ex == arrayExceptions[2]){
                    Console.WriteLine("Вызвано исключение arrayExceptions[2]");
                }
                else if (ex == arrayExceptions[3]){
                    Console.WriteLine("Вызвано исключение arrayExceptions[3]");
                }
                else if (ex == arrayExceptions[4]){
                    Console.WriteLine("Вызвано исключение arrayExceptions[4]");
                }
            }
            finally{
                Console.WriteLine("Finally-блок");
            }
        }
    }
}