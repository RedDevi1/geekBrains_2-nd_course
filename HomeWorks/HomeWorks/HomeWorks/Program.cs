using HomeWorks.Lesson_1.Exercise_1;
using System;

namespace HomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfLesson = 1;
            var numOfExercise = 0;
            var nl = 0;
            var ne = 0;
            Console.WriteLine("Тест задания 1 урока {0} для числа 7:", numOfLesson);
            Test_Lesson_1_Exercise_1(5, true);
            Console.WriteLine("Тест задания 1 урока {0} для числа 6:", numOfLesson);
            Test_Lesson_1_Exercise_1(6, false);
            Console.WriteLine("Тест задания 1 урока {0} для числа 8:", numOfLesson);
            Test_Lesson_1_Exercise_1(8, false);
            Console.WriteLine("Тест задания 1 урока {0} для числа -7:", numOfLesson);
            Test_Lesson_1_Exercise_1(-7, false);
            Console.WriteLine("Тест задания 1 урока {0} для числа -8:", numOfLesson);
            Test_Lesson_1_Exercise_1(-8, false);
            Console.WriteLine("Список доступных уроков: {0}", numOfLesson);
            Console.WriteLine("Список доступных заданий из урока {0}: 1-3", numOfLesson);
            do
            {               
                Console.WriteLine("Введите номер урока");
                nl = Convert.ToInt32(Console.ReadLine());
                if (nl < 0 || nl > numOfLesson)
                {
                    Console.WriteLine("Номер урока должен быть в пределах от 0 до {0}", numOfLesson);
                }
                    
            }
            while (nl < 0 || nl > numOfLesson);
            switch (nl.ToString())
            {
                case "1": numOfExercise = 3; break;
            }
            do
            {
                Console.WriteLine("Введите номер задания");
                ne = Convert.ToInt32(Console.ReadLine());
                if (ne < 0 || ne > numOfExercise)
                {
                    Console.WriteLine("Номер задания должен быть в пределах от 0 до {0}", numOfExercise);
                }                   
            }
            while (ne < 0 ||ne > numOfExercise);
            Console.Clear();
            if (nl == 1 && ne == 1)
            {
                Console.WriteLine("Введите число");
                var num = Convert.ToInt32(Console.ReadLine());
                SimpleNum number = new SimpleNum(num);
                number.IsSimpleNum(num);
                if (number.IsSimpleNum(num))
                    Console.WriteLine("Число {0} является простым", num);
                else
                    Console.WriteLine("Число {0} является непростым", num);
            }
            else if (nl == 1 && ne == 2)
            {
                Console.WriteLine("Асимптотическая сложность функции равна O(N^3)");
            }
            else if (nl == 1 && ne == 3)
            {
                Console.WriteLine("Введите число для поиска Фибоначчи");
                var num = Convert.ToInt32(Console.ReadLine());
                Fibo number = new Fibo(num);
                Console.WriteLine("Число Фибоначчи для {0} через цикл равно {1}, через рекурсию равно {2}", num, number.FiboByCycle(num), number.FiboByRecurse(num));
            }
        }
        static void Test_Lesson_1_Exercise_1 (double num, bool expected)
        {
            SimpleNum number = new SimpleNum(num);   
            var actual = number.IsSimpleNum(num);
            if (actual == expected)
                Console.WriteLine("VALID TEST");
            else
                Console.WriteLine("INVALID TEST");
        }
    }
}
