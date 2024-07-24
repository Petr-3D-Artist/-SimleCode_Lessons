using System;
using System.Globalization; 


namespace Tasks

{
    internal class Tasks
    {
        static void Main(string[] args)
        {                                   // Tasks #1
                                            // Task 1 // Напишите программу, вычисляющую среднее арифметическое двух чисел
            /*
            double firstValue, secondValue; // Переменные

            Console.WriteLine("Введите число 1");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите число 2");

            secondValue = double.Parse(Console.ReadLine());

            double result = (firstValue + secondValue) / 2; // Результат всех сложений этих переменных

            Console.WriteLine("Среднее арифметическое двух чисел = " + result);
            */


            // Task 2 // Введите три числа и выведите на экран значение суммы и произведения этих чисел
            /*
            double firstValue, secondValue, thirdValue; // Переменные
            Console.WriteLine("Введите число 1");
            firstValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 2");
            secondValue = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число 3");
            thirdValue = double.Parse(Console.ReadLine());
            double sumResult = firstValue + secondValue + thirdValue; // Результат всех сложений этих переменных плюсы
            double multResult = firstValue * secondValue * thirdValue; // Результат всех сложений этих переменных умножение
            Console.WriteLine("Сумма трех чисел " + sumResult); // Прибавление +
            Console.WriteLine("Произведение трех чисел " + multResult); // Умножение *
            */

            // Task 3 // Напишите простой конвертер валют (без возможности динамического выбора валюты пользователем). Валюты заданы хардкодом и не изменятся.
            // Тип валют на выбор программиста.
            /*
            double UsdToRub = 32.2;
            double UsdToUah = 20.5;
            double USD;

            Console.WriteLine("Введите сумму в USD"); 
            USD = double.Parse(Console.ReadLine());

            Console.WriteLine(USD + " USD в RUB = " + USD + UsdToRub); // конвертирует Доллары в рубли
            Console.WriteLine(USD + " USD в UAH = " + USD + UsdToUah); // Конвертирует Доллары в Гривны
            */


            //Tasks #2 

            //Task 1
            // Напишите программу, проверяющую число, введенное с клавиатуры на четность
            /*
            int a;
            a = int.Parse(Console.ReadLine());
            if (a % 2 ==0) // if принмает в () скобках булевые операции true или false (a делим на 2 и сравниваем с 0)
            {
                Console.WriteLine("Число четное");
            }
            else
            {
                Console.WriteLine("Число не четное");
            }
           */

        }


    }
}

 