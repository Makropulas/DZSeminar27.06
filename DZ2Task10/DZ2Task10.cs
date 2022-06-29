// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите трёхзначное число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = number.ToString();

            Console.WriteLine("--------------------------------");

            if (number < 0)
            {
                Console.WriteLine("Число не должно быть отрицательным");
            }
            else if (str.Length == 3) // Программа работает, но почему здесь Length подсвечивается белым?
            {
                char secondDigit = str[1];
                Console.WriteLine($"Вторая цифра в вашем числе: {secondDigit}");
            }
            else
            {
                Console.WriteLine("Вы неверно ввели число. Пожалуйста, начните сначала");
            }
        }
    }
}

// Почему-то при введении числа, состоящего из более чем девять символов, вылетает ошибка