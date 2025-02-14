using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  class Program
  {
    static void Main(string[] args) {
      Console.WriteLine("Выберите действие. \nНажмите 1 для того чтобы в введенном числе зачеркнуть вторую цифру и добавить её в конец\nНажмите 2 для того чтобы возвести число в степень");
      string message = Console.ReadLine();
      switch (message)
      {
        case "1":
          Console.WriteLine("Введите число, в котором вы хотите зачеркнуть вторую цифру");
          int firstNumber = Convert.ToInt32(Console.ReadLine());
          int test = firstNumber;
          int count1 = 0;
          while (test > 0)
          {
            test /= 10;
            count1++;
          }
          int eraser = 1;
          string result1 = "";
          for (int count = 0; count < --count1; ++count)
          {
            eraser *= 10;
          }
          string erasedDigital = Convert.ToString((firstNumber * 10 / eraser) % 10);
          for (int i = 0; i < count1; ++i)
          {
            if (i != count1 - 2)
              result1 = Convert.ToString(firstNumber % 10) + result1;
            firstNumber /= 10;
          }
          result1 += erasedDigital;
          Console.WriteLine($"Великолепно! Вот ваше число: {result1}");
          break;
        case "2":
          Console.WriteLine("Введите основание степени");
          int value = Convert.ToInt32(Console.ReadLine());
          Console.WriteLine("Введите показатель степени");
          int cycles = Convert.ToInt32(Console.ReadLine());
          int result = 1;
          for (int count = 0; count < cycles; ++count)
          {
            result *= value;
          }
          Console.WriteLine($"Ваш результат: {result}");
          break;
      }


    }
  }
}
