// using System.Configuration;

using System;
using System.CodeDom;

namespace _SimleCode_Lessons
{
    internal class Lessons
    {
        static void Main(string[] args)
        {                                          // Lesson 4 and 5  // Типы данных // ПЕРЕМЕННЫЕ // ИНИЦИАЛИЗАЦИЯ

            //ЧИСЛОВЫЕ (ЦЕЛОЧИСЛЕННЫЕ) ТИПЫ:
            //тип_переменной имя_переменной;
            //int a; // int a = 5; - можно сделать так - но убираем ниже а = 5; // можно сделать так int a,b; - теперь 2е переменные

            //a = 5; // a - это переменная = это оператор присваивания
            // ЛОГИЧЕСКИЙ ТИП:
            //bool variable = false; // У нас в коде не может быть 2 одинаковых названия переменных
            //bool variable = true; // нужно сменить имя, или добавить, изменить в ней что-то - variable1

            // ЧИСЛОВЫЕ (с плавающей точкой) типы: 
            //double a = 1.33;
            // СИМВОЛЬНЫЕ ТИПЫ: 
            //char a = '#' // одинарные ковычки
            //string a = "dasda" // двойные ковычки
            //Console.WriteLine(a); // вывод переменной в консоль // Console - это класс // WriteLine- это метод // (a) - наша переменная


            // Lesson 6. - Ввод данных в консоль
            /*
            string data;
            data = Console.ReadLine(); // RedLine для получения данных и корректной обрабодке () сюда он не принимает никаких параметров, ничего не пишем
            Console.WriteLine(data);
            Console.WriteLine("Hi " + data +"!!!");// если делаем пробел в скобках и ставим + то это Кондетенация (обьеденение строк) и добавляем после + data (наша переменная)  и теперь если скопилировать и написать в строку консоли - то будет Hi"Название что напишем"
            */
            // можно дабавить еще один + после data и "!!!"


            // Lesson 7. КОНВЕРТАЦИЯ СТРОКИ В ЧИСЛО

            //int a = 5; // таким образом без "ковычек" мы сложим числа 5 + 10, а в ковычках получится 510 сложение этих строк
            //int b = 10; // таким образом без "ковычек" мы сложим числа 5 + 10, а в ковычках получится 510 сложение этих строк

            //Console.WriteLine(a + b); // таким образом без "ковычек" мы сложим числа 5 + 10 получим при компиляции 15, а в ковычках получится 510

            //! с помощью класса Convert можно конвертировать в "в скобках" 
            /*
            string str = "5";

            int a = Convert.ToInt32(str); // теперь наша "5" конвертируется в число 5, а не как символ
            Console.WriteLine(a);
            */

            // Если у нас . а не , в дробных числах:
            // Выше нужно вписать using System.Globalization;
            /*
           string str = "1.9";

           NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
           {
               NumberDecimalSeparator = ".", // NumberDecimalSeparator  - он носит строковую форму и сдесь указываем какой разделитель мы используем в дробных числах
           };

           double a = Convert.ToDouble(str, numberFormatInfo); //сюда добавляем numberFormatInfo  2ым параметром
           Console.WriteLine(str);
           */


            //Lesson 8. ПРЕОБРАЗОВАНИЕ СТРОК - PARSE STRING - TRYPARSE STRING 
            /*
            string str = "5";
            int a = int.Parse(str); // Parse - работает только со строчками, конвертирует
            Console.WriteLine(str);
            */
            // Если дробное число:
            /*
            string str = "5,9";
            double a = double.Parse(str);
            Console.WriteLine(str);

            // Если с точкой:
            /*
            string str = "5.9";
            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            { 
                NumberDecimalSeparator = ".",
            };
            double a = double.Parse(str, numberFormatInfo);
            Console.WriteLine(str);
            */

            //Tryparse - он принимает как минимум 2 параметра // тоже конвертирует
            /*
            string str = "1";
            int a;
            int.TryParse(str,out a); // out - значит даннaе переменная будет модифицирована внутри метода, инициализирована и возвращена наружу
            Console.WriteLine(a);
            */


            // LESSON 9. ЗАКРЫВАЕТСЯ КОНСОЛЬ C# ЧТО ДЕЛАТЬ
            // Example:
            /*
            Console.ReadLine(); // Что бы консоль ожидала ввод и не пропадала(или RaadKey)
            */


            // LESSON 10. ОПЕРАТОРЫ. АРИФМЕТИЧЕСКИЕ ОПЕРАЦИИ С ЧИСЛАМИ В C# 
            // Оператор - это конструкция языка программирования, некие синтаксические конструкции, которые позволяют производить какие либо операции над данными, оперирует с данными.
            // 2 + 5 // + это оператор который выполняет операцию над 2мя операндами 2 и 5. 
            // Example:
            /*
            int a = 2;
            int b = 5;
            int result = a + b;
            Console.WriteLine(result);
            */
            // Example: // Если хотим дробные, деление:
            /*
            double a = 2;
            int b = 5;
            double result = a / b;
            Console.WriteLine(result);
            */
            // Example: //Можно и так c делением:
            /*
            int a = 2;
            int b = 5;
            double result = (double) a / b;
            Console.WriteLine(result);
            */

            //Example: // Операция остатка отделения:
            /*
            int a = 2;
            int b = 5;
            double result = (double)a % b;
            Console.WriteLine(result); // В 5 помещается 2ве 2ки, значит получится 2
            */

            // Можно не писать пеменную, а сразу число:
            /*
            int a = 2;
            int result = a + 5;
            Console.WriteLine(result);
            */


            // Lesson 11. ПРИОРИТЕТ АРИФМЕТИЧЕСКИХ ОПЕРАЦИЙ C#
            // 
            /*
            int result = 2 + 2 * 2;
            Console.WriteLine(result); // получим 6 - т.к. сразу умножаем, а потом +
            */

            // Как и в математике, мы можем спомощью () изменить приоритет - сразу будет считать в скобках.
            /*
            int result = (2 + 2) * 2;
            Console.WriteLine(result); // Получится 8 из-за приоритета в скобках
            */

            //Если приоритет одинаковый - то считает с лево на право:
            /*
            int result = 2 - 1 + 2;
            Console.WriteLine(result); // получим 3
            */


            //Lesson 12. Несколько проектов в одном решении.
            // В тетраде записано

            //Lesson 13. Средненее арифметических чисел - конвертер валют
            // Tasks #1
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


            //Lesson 14. 14.ИНКРЕМЕНТ И ДЕКРЕМЕНТ - ПОСТФИКСНЫЙ И ПРЕФИКСНЫЙ - C# 

            //Инкремент - Это операция увеличения значения на единицу 
            //Декремент - Это уменьшение значение на единицу. которая имеет очень удобную степень записи.
            // Операция Инкремента  выглядит так a++; // переменная а будет увеличина на единицу 
            /*
            int a = 0;
            a++;
            Console.WriteLine(a);
            */
            //Декремент:
            /*
            int a = 0;
            a--;
            a--; // тогда уменьшится еще на одну единицу и получим -2
            Console.WriteLine(a);  
            */
            /*
            // Постфекснный и префекснный форма записи
            a++; - Это постфикснный
            ++а; - Это префекснный
            */
            // Приоритет:
            /*
            int a = 0;
            Console.WriteLine(++a); // префекснный - получим единицу - главный приоритет
            Console.WriteLine(a++); // постфикснный - получим 0 
            */
            // Так же и декремент 


            //Lesson 15.ОПЕРАЦИИ СРАВНЕНИЯ - ОПЕРАТОРЫ ОТНОШЕНИЯ - C# 

            //Виды операторов отношений:
            /*
            == Равно
            != Не равно
            > Больше
            < Меньше
            >= Больше илиравно
            <= Меньше или равно
            */
            //Example:
            /*
            int a = 5;
            int b = 5;
            Console.WriteLine(a == b);
            */


            //Lesson 16.IF ELSE C# - КОНСТРУКЦИЯ ЛОГИЧЕСКОГО ВЫБОРА - ВЕТВЛЕНИЕ В C# 

            // Конструкция выглядит так:
            /*
             if (Утверждение или выражение)  - Переменная в формате bool
            {
            Действие 1; // true
            }
            else
            {
            Действие 2; // false
            }
            */
            // if - если
            //else - иначе

            //Example: Потипу персонаж болен и его предупреждают:
            /*
            bool isInfected = true; // если будет false - то нижний блок кода он пропустит "Персонаж инфецирован" и появится "Персонаж здоров"
            if (isInfected)
            {
                Console.WriteLine("Персонаж инфецирован"); // Выполнится если будет bool isInfected = true;

            }
            else
            {
                Console.WriteLine("Персонаж здоров"); // Выполнится если будет bool isInfected = false;
            }
            */

            //Example: С оператором сравнений:
            /*
            int a;
            a = int.Parse(Console.ReadLine());
            if (a == 5)
            {
                Console.WriteLine("а равно 5");
            }
            else
            {
                Console.WriteLine("а не равно 5");
            }
            */


            // Lesson 17.ЛОГИЧЕСКИЕ ОПЕРАТОРЫ C# - СОКРАЩЁННЫЕ ЛОГИЧЕСКИЕ ОПЕРАЦИИ

            //Логические операторы:
            /*
             * &&   Сокращенное И // Этот оператор быстрее
             * ||   Сокращенное ИЛИ // Этот оператор быстрее
             * &    и // Используют редко // проверяют все строчки кода, вот и медленее
             * |    Или // Используют редко // проверяют все строчки кода, вот и медленее
             * !    Не (унарный) // Инвертирует перед ним значение 
            */

            //Example: Оператор ! (не)
            /*
            bool isInfected = false; // тут должно быть false - ! он инвертирует в true
            if (!isInfected) // И если наш перс. не инфецирован - то появится сообщение "Персонаж здоров".
                             // Вот этот оператор ! - он инвертирует то значение, что находится перед ним c false в truе
            {
                Console.WriteLine("Персонаж здоров");
            }
            */
            //Example: Оператор && (Сокращенное И)
            /*
            bool isHighTemperature = true;
            bool hasNoCooling = true; 
            if (isHighTemperature && hasNoCooling) // Если высокая температура и нет охдаждения выведите в консоль "Угроза повреждения процессора"
            {
                Console.WriteLine("Угроза повреждения процессора"); // Если везде true - топоявится сообщение
            }
            */
            //Example: Оператор || (Сокращенное ИЛИ):
            /*
            bool isHighTemperature = true;
            bool hasNoCooling = true;
            if (isHighTemperature || hasNoCooling) 
            {
                Console.WriteLine("Угроза повреждения процессора"); // bool isHighTemperature ИЛИ hasNoCooling
                                                                    // Если где-то будет false и true, true и true - он выведет сообщение
            }
            */


            //Lesson 18.ПРОВЕРКА ЧИСЛА НА ЧЁТНОСТЬ В C#
            // Task - Done
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


            // Lesson 19. 19.SWITCH C# - ЧТО ЭТО - ПРИМЕР - СИНТАКСИС - ОПЕРАТОР МНОЖЕСТВЕННОГО ВЫБОРА - C# 

            //Switch:
            /*
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1: 
                    Console.WriteLine("Вы ввели число 1"); // если ввести 1 ввыведит текст в консоль 
                    break;
                case 2:
                    Console.WriteLine("Вы ввели число 2"); // если ввести 2 ввыведит текст в консоль 
                    break;
                default: // Если ввести не 1 или 2, а другое число то он напишет - Я не знаю, что делать с этим числом!
                    Console.WriteLine("Я не знаю, что делать с этим числом!");
                    break;
            }
            */

            // Тексты, символы:
            /*
            string a = Console.ReadLine();
            switch (a)
            {
                case "+":
                    Console.WriteLine("Вы ввели +"); // если ввести 1 ввыведит текст в консоль 
                    break;
                case "-":
                    Console.WriteLine("Вы ввели -"); // если ввести 2 ввыведит текст в консоль 
                    break;
                default: // Если ввести не 1 или 2, а другое число то он напишет - Я не знаю, что делать с этим числом!
                    Console.WriteLine("Я не знаю, что делать с этим символом!");
                    break;
            */
            /*
            {
                ConsoleKey consoleKey = Console.ReadLine().Key; // с помощью этой записи мы будем получать информацию о том какая конкретно клавиша была нажата на клавиатуре
                switch (switch_on) // в (switch_on) копирует consoleKey и вставляем в (switch_on) и получем (consoleKey) и в свободном поле нажимаем на ЛКМ и он нам сделает целый список команд с клавишами
                {
                    default:
                }
            */
            // Lesson 20.ПИШЕМ КАЛЬКУЛЯТОР НА C# - КАК НАПИСАТЬ КАЛЬКУЛЯТОР НА C# - C# ДОМАШНИЕ ЗАДАНИЯ - #3
            /*
            while (true) // Цикл, повторения кода while несколько раз, он будет ниже код повторять бессконечно 
            {
                Console.Clear(); // Clear - Очищает консоль (калькулятор) когда весь цикл по коду сделан, жмем Enter все чистится и вводим новые данные в калькулятор
                double firstValue, secondValue;
                string action;
                try
                {
                    Console.WriteLine("Введите первое число"); // Если тут возникает ошибка, то мы попадем в блок catch (Exception)
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Введите второе число");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception) // Блок catch (Exception)
                { 
                    Console.WriteLine("Не верный ввод, введите число");
                    Console.ReadLine(); // Ждет консоль ввода и не закрывается, как бы останавливает ее
                    continue; // это приведет к тому, что код, что ниже выполняться не будет и мы попадем в начала нашего цикла while
                }

                Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(firstValue + secondValue);
                        break;
                    case "-":
                        Console.WriteLine(firstValue - secondValue);
                        break;
                    case "*":
                        Console.WriteLine(firstValue * secondValue);
                        break;
                    case "/":
                        if (secondValue == 0)
                            Console.WriteLine(0); // Если делим на ноль будет 0 
                        else
                            Console.WriteLine(firstValue / secondValue); // если делим не на 0 то будет деление
                        Console.WriteLine(firstValue / secondValue); // на 0 не делится и может вылетать программа, но можно сделать как выше и все будет норм
                        break;
                    default:
                        Console.WriteLine("Не вверный ввод"); // Будет это сообщение если введем что-то другое
                        break;
                }

                Console.ReadLine(); // Ждет консоль ввода и не закрывается, как бы останавливает ее
            }
            */


            // LESSON 21.ЦИКЛ WHILE - ЧТО ЭТО - КАК РАБОТАЕТ.
            //Цикл - повторить код сколько нужно, хоть бессконечно
            /*
             int count = 0; // Счетчик итераций повторений
             while (true) //While - цикл, (true) - тут условия до какого будет выполнятся цикл
             while (count < 10) // Так он выполнит 10 итераций
             { // в скобочках находится тот вариант который будет зациклен и будет повторятся
                 count++;
                 Console.WriteLine("Выполняем действие");
             }
             */

            //Сделаем так ,что мы впишем кол-во в консоле и столько он нам сделает повторенй:
            /*
            int count = 0; 
            int limit = int.Parse(Console.ReadLine()); // Прямо в консоле можем написать кол-во повторений 
            while (count < limit) 
                { 
                    count++;
                    Console.WriteLine("Выполняем действие");
                }
            */


            // Lesson 22.ЦИКЛ DO WHILE - ЧТО ЭТО - КАК РАБОТАЕТ 
            /*
            do // сразу выполняет действие в {} // do while всегда выполняет хотя бы одно действие, не важно что стоит true или false
            {
                Console.WriteLine("Действие"); // тут логика какого-то действия
            } while (true); // потом проверяет истинность условия
            */

            // Lesson 23.СУММА И КОЛИЧЕСТВО ЧЕТНЫХ И НЕЧЕТНЫХ ЧИСЕЛ В ДИАПАЗОНЕ - C# ДОМАШНИЕ ЗАДАНИЯ - #4

            //Task:
            //uint - не может хранить отрицательные числа
            /*
            uint oddNumbersCount = 0; //Нечетные числа //oddNumbers четное число
            uint evenNumbersCount = 0; //Четные числа //evenNumbers нечетное число

            int oddNumbersSum = 0; //Что бы показыва сумму четных или нечетных чисел
            int evenNumbersSum = 0;

            Console.WriteLine("Введите первое число диапазона");
            int currenValue = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите последнее число диапазона");
            int limit = int.Parse(Console.ReadLine()); // До какого числа нужно подсчитывать четные или нечетные числа

            while (currenValue <= limit) //currenValue должна быть меньше чем limit - если это так то у нас будет true
            {
                if (currenValue % 2 == 0) //currenValue - проверяется четная или нет
                {                                      
                    evenNumbersCount++;
                    evenNumbersSum = evenNumbersSum + currenValue; // Есть сокращение evenNumbersSum += currenValue;
                }
                else
                {
                    currenValue++;
                    oddNumbersSum = oddNumbersSum + currenValue;                   
                }

                Console.WriteLine("Количество нечетных чисел: " + oddNumbersCount);
                Console.WriteLine("Количество четных чисел: " + evenNumbersCount);
                Console.WriteLine("Сумма нечетных чисел: " + oddNumbersSum);
                Console.WriteLine("Сумма четных чисел: " + evenNumbersSum);
                Console.ReadLine(); //Что бы консоль не закрыввалсь 

            }   
            */

            // Lesson 24.C# ЦИКЛ FOR - C# 
            /*
                for (int i = 0; i < 10; i++) // пишем For и жмем два раза Tab - и он нам сгенерирует весь синтексис For
                                                 //int i = 0; -  переменной i и присваеваем 0
                                                 //i < length; - Условие выполнение цикла (это как в цикле while (true))
                                                 // i++  - операция инкремента над которой выполняется над переменной i
                                                 // i < length; сделаемтак i < 10; он посчитает до 9
                                                 // i < 10; - тут у нас условия 
                {
                    Console.WriteLine(i);
                }
            */

            // LESSON 25.C# ЦИКЛ FOR - В ОБРАТНОМ ПОРЯДКЕ - НЕСКОЛЬКО ПЕРЕМЕННЫХ - НЕСКОЛЬКО УСЛОВИЙ 

            // Можно не использовать что ниже:
            // for (int i = 0; i < 10; i++) 

            // Можно вот так:
            /*
            for (;;) // у нас тут ничего нет, нет проверки цикла - тогда выполянется бесконечно

            {
                Console.WriteLine("For is working");
                System.Threading.Thread.Sleep(300); // замедлить работу программы на 300 мили/с каждую этэрацию цикла
                break; // прирывает цикл
            }

            Console.ReadLine();
            */

            //Вот пример работы с двумя циклами:
            /*
            int i = 0;

            for (; i < 3; i++)
            {
                Console.WriteLine("for_1: " + i); // посчитает с 0 до 2
            }
            for (; i < 5; i++) // продолжение цикла
            {
                Console.WriteLine("for_2: " + i); //посчитает от 3 до 4
            }

            Console.ReadLine();
            */

            //Изменения до цикла, после цикла:
            /*
            for (int i = 0; i < 5; )
            {
                i++; // изменения до цикла - посчитает от 1 до 5
                Console.WriteLine(i);
                // если тут i++; - то после цикла - посчитает от 0 до 4
            }
            Console.ReadLine();
            */

            //Как в For поместить несколько переменных:
            /*
            for (int i = 0, j = 5; i < 10 && j < 12; i++,j++) // Через запятую добав. еще переменную int i = 0,j = 5; 
                                                    // если хотим ,что бы он выводил счет, а не одну цифру то к i++ добавляем j++ через запятую
            {                                       // Если хотим добавить какое-то условие то добавим - && j < 12 вот прмер i < 10 && j < 12;
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            */

            //Цикл For  выполняется в  обрятном порядке, назад:
            /*
            int i = int.Parse(Console.ReadLine()); // Теперь мы можем задавать число и от него будет счет

            for (int i = 5; i >= 0; i--) // int i = 5; - тут ставим 5
                                         // i < 5; меняем на  i > 0;
                                         // i++ меняем на  i-- и теперь у нас идет отсчет назад
                                         // если хотим добавить 0 то i > 0; меняем на  i >= 0;
            {
                Console.WriteLine(i);
                
            }
            */

            // Теперь мы можем задавать число в консоле и от него будет идти  отсчет:
            /*
            int i = int.Parse(Console.ReadLine());
            for (; i >= 0; i--) 
            {
                Console.WriteLine(i);
                 
            }
            Console.ReadLine();
            */

            // Делаем отсчет назад и вперед:
            /*
            for (int i = 0, j = 5; i < 5; i++, j--) 
                                                    
            {                                       
                Console.WriteLine("i: " + i);
                Console.WriteLine("j: " + j);
            }
            Console.ReadLine();
            */


            //LESSON 26.КЛЮЧЕВОЕ СЛОВО BREAK - ОПЕРАТОР BREAK - ПРИМЕР - СИНТАКСИС - C# 
            // break; - блокирует цикл выполнения 
            /*
            for (int i = 0; i  < 100; i++)
            {
                string msg = Console.ReadLine();
                if (msg == "Exit") // Если мы впишим Exit в консоль это слово, то он остановит все действия
                {
                    break; //Можно писать что-то до 100 раз пока не остановим введя Exit
                }
                Console.WriteLine(i);
            }
            Console.ReadLine(); 
            */


            //LESSON 27.КЛЮЧЕВОЕ СЛОВО CONTINUE- ОПЕРАТОР CONTINUE
            //continue; - позволяет прирвать какую-то этерацию цикла не выходя из нее
            /*
            for (int i = 0; i < 5; i++)
            {
                if (i == 2) // Если значение в переменной i будет равна 2 то выполняется continue;
                {
                    continue; // Он прирвет итерацию цикла на 2ке, ее не будет в счете и начнет как бы заново с 3 4, будет  0 1 3 4 
                }

                Console.WriteLine(i);
            }

            Console.ReadLine();
            */


            //LESSON 28.ВЛОЖЕННЫЕ ЦИКЛЫ  - КАК РАБОТАЮТ





















        }

    }

}
