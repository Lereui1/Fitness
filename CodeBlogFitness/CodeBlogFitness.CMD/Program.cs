using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System;

namespace CodeBlogFitness.CMD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует приложение CodeBlogFitness");

            Console.WriteLine("Введите имя пользователя");

            var name = Console.ReadLine();

            Console.WriteLine("Введите пол: ");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения: ");
            var birthdate = DateTime.Parse(Console.ReadLine()); // TODO: Переписать

            Console.WriteLine("Введите вес: ");
            var weight = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост: ");
            var height = Double.Parse(Console.ReadLine());

            var userController = new UserController(name, gender, birthdate, weight, height);
            userController.Save();

        }
    }
}
