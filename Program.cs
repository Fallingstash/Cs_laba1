using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие. \nНажмите 1 для того чтобы в введенном числе зачеркнуть вторую цифру и добавить её в конец\nНажмите 2 для того чтобы возвести число в степень");
            string userResponse = Console.ReadLine();
            switch (userResponse)
            {
                case "1":
                    Console.WriteLine("Введите число, в котором вы хотите зачеркнуть вторую цифру");
                    int value = Convert.ToInt32(Console.ReadLine());
                    string result = EraseAndDrawDigital(value);
                    Console.WriteLine($"Великолепно! Вот ваше число: {result}");
                    break;

                case "2":
                    Console.WriteLine("Введите основание степени");
                    int value1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите показатель степени");
                    int cycles = Convert.ToInt32(Console.ReadLine());

                    int result1 = PowBySoldatov(value1, cycles);
                    Console.WriteLine($"Ваш результат: {result1}");
                    break;

                default:
                    Console.WriteLine("Неверный формат. Пожалуйста, выберите 1 или 2");
                    break;
            }
        }
        static string EraseAndDrawDigital(int firstNumber)
        {
            int quantityCheck = firstNumber;
            int countDigitals = 0;

            while (quantityCheck > 0)
            {
                quantityCheck /= 10;
                countDigitals++;
            }

            int placeErasedNumber = 1;
            string result = "";

            for (int count = 0; count < countDigitals - 2; ++count)
            {
                placeErasedNumber *= 10;
            }
            string erasedDigital = Convert.ToString((firstNumber / placeErasedNumber) % 10);

            for (int i = 0; i < countDigitals; ++i)
            {
                if (i != countDigitals - 2)
                {
                    result = Convert.ToString(firstNumber % 10) + result;
                }
                firstNumber /= 10;
            }
            result += erasedDigital;
            return result;
        }
        static int PowBySoldatov(int value, int quantity)
        {
            int result = 1;
            for (int count = 0; count < quantity; ++count)
            {
                result *= value;
            }
            return result;
        }
    }
}
