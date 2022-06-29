// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());
            string str = number.ToString();

            Console.WriteLine("--------------------------------");

            if (number < 0)
            {
                Console.WriteLine("Число не должно быть отрицательным");
            }
            else if (str.Length > 2) // Тот же вопрос: Программа работает, но почему здесь Length подсвечивается белым?
            {
                char secondDigit = str[2];
                Console.WriteLine($"Третья цифра в вашем числе: {secondDigit}");
            }
            else
            {
                Console.WriteLine($"В числе {number} нет третьей цифры");
            }
        }
    }
}

// А в этой программе, почему-то, ошибка вылетает при введении числа, состоящего из более чем ДЕСЯТЬ символов