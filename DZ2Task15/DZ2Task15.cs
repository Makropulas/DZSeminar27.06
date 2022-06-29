// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

namespace DZ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Введите цифру дня недели: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("--------------------------------");

            if (number > 5 && number < 8) Console.WriteLine("УРА! Этот день недели является выходным");
            
            else if (number < 1 | number > 7) Console.WriteLine("Ой! В неделе всего семь дней (с 1 по 7)");
            
            else Console.WriteLine("К сожалению, этот день недели не является выходным");
        }
    }
}

// Вычитал, что если блок if содержит одну инструкцию, то мы можем его сократить, убрав фигурные скобки