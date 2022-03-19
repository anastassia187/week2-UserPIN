using System;

namespace UserPIN
{
    class Program
    {
        static void Main(string[] args)
        {
            //приложение просит пользователя ввести PIN-код
            //если веденный Pin-код "1234", то приложение приветствует пользователя
            //и спрашивает его имя. А затем приветствует пользователя по имени.
            //в ином случае, консоль выводит на экран сообщение об ошибке Invalid PIN.


            Console.WriteLine("Please enter PIN!");
            string userName = Console.ReadLine();
            if (userName == "1234")
            {
                Console.WriteLine("Welcome!");
                Console.WriteLine("What is your name?");
                string userFirstName = Console.ReadLine();
                Console.WriteLine(" Hello, " + userFirstName + "!");

            } else


            {
                Console.WriteLine("Invalid PIN!");
               

            }
                
            

                
            }

        }
    }

;
