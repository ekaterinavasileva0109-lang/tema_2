using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тема2
{
    public class Program
    {
        public static void Main()
        {
            var calc = new calculator();
            Console.WriteLine(calc.Add(10, 5));
            Console.WriteLine(calc.divide(10, 5));

            var user = new User(1, "ivan", "ivan@mail.ru", "Иван Иванов", 25);
            user.PrintInfo();
        }
    }
    public class calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        private double Dev(double x, double y)
        {
            if (y == 0)
                throw new DivideByZeroException("");
            return x / y;
        }
        public double divide(double x, double y)
        {
            return Dev(x, y);
        }
    }
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }

        public User(int id, string login, string email, string fullName, int age)
        {
            Id = id;
            Login = login;
            Email = email;
            FullName = fullName;
            Age = age;
            RegistrationDate = DateTime.Now;
            IsActive = true;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Логин: {Login}, Email: {Email}, " +
                              $"Имя: {FullName}, Возраст: {Age}, " +
                              $"Зарегистрирован: {RegistrationDate:d}, Активен: {IsActive}");
        }
    }
}
