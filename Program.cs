using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_13
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<User> users = new List<User>();
            
            users.Add(new User("Petya ", 123, "01.05.2017", 15));
            users.Add(new User("Vasya ", 124, "01.06.2017", 18));
            users.Add(new User("Tolik ", 125, "02.05.2018", 22));
            users.Add(new User("Anton ", 126, "03.05.2018", 21));
            users.Add(new User("Valya ", 126, "04.05.2021", 25));

            users.Add(new User("Petya2", 223, "05.05.2015", 16));
            users.Add(new User("Vasya2", 124, "01.05.2017", 18));
            users.Add(new User("Tolik2", 225, "07.05.2015", 20));
            users.Add(new User("Anton2", 226, "08.05.2015", 23));
            users.Add(new User("Valya2", 226, "09.05.2015", 24));

            users.Add(new User("Petya3", 323, "21.05.2014", 15));
            users.Add(new User("Vasya3", 324, "21.05.2014", 30));
            users.Add(new User("Tolik3", 325, "21.05.2014", 26));
            users.Add(new User("Anton ", 326, "21.05.2013", 31));
            users.Add(new User("Valya ", 326, "21.05.2013", 28));


            // Average: подсчитывает cреднее значение числовых значений в коллекции
            Console.WriteLine($"Среднее значени возраста :\t{users.Average(n => n.Age) + " - года "}");

            // - Вывод минимального пользователя (по возрасту)
            Console.WriteLine( $"Выво минимального пользователя (по возрасту): \t{users.Min(n => n.Age) + " - лет " }");

            // - Реализовать метод который уберет все повторения логина и / или пароля
            
            Console.WriteLine( $" все повторения  пароля: \t  ");
           // Убрать дубли
           var res = users.Distinct(new RemoveReplays());
            foreach(var i in users.Distinct(new RemoveReplays()))
            {
               System.Console.WriteLine(i);
            }

            // - Количества пользователей, кто зарегистрировался в определенную дату
            //   (принимать в параметры)
             Console.WriteLine("\nВведите дату регистрации - (день.мес.год -> 00.00.0000)");
             string str;
             str = Console.ReadLine();
             Console.WriteLine( $"Пользователи, кто зарегистрировался в определенную дату:"+
                                $" {users.Count(n => n.RegistrationDate == str) + " - человек " }");

            Console.ReadLine();
        }
    }
}
