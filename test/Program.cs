using System;
using test.Models;

namespace test
{
    class Program
    {
        /*User class

- Username
- Age
- Password

Username, password property-ləri olmadan user obyekti yaratmaq olmaz.

Age propery-i mənfi ola bilməz.

Password property-i bu şərtləri ödəməlidir:

1. Boş ola bilməz
2. Uzunluğu 8-dən kiçik ola bilməz
3. İçində ən az bir böyük hərf olmalıdır
4. İçində ən az bir rəqəm olmalıdır

Üçüncü və dördüncü şərti ayrı bir private methodda yazıb gəlib propertyinin setində istifadə etmək lazımdır.
*/
        static void Main(string[] args)
        {
            do
            {
             Userclass user = new Userclass();
            Console.Clear();
            Console.Write("Please enter your username: ");
            user.username = Console.ReadLine();
            Console.Write("Please write your age: ");
            user.age = int.Parse(Console.ReadLine());
            Console.Write("Please enter your password: ");
            user.pass = Console.ReadLine();
           
                Console.WriteLine("for next press to any key::");
                Console.WriteLine("for exit press to esc::");
            }
            while (Console.ReadKey().Key!=ConsoleKey.Escape);
        }
    }
}
