using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Program_1_Овчарук_Шурдук_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 1.
            //Запросить у пользователя 5 слов, после чего вывести дважды каждое нечетное слово и трижды каждое четное слово.
            //Между выводимыми словами ставить разделитель в виде "!".
            //Дать окну консоли название "Программа№_(фамилия)".

            /*Title = "Программа№1 (Шурдук_Овчарук)";
            WriteLine("Введите 5 слов!");
            Write("Введите первое слово: ");
            string word_1 = ReadLine();
            Write("Введите второе слово: ");
            string word_2 = ReadLine();
            Write("Введите третье слово: ");
            string word_3 = ReadLine();
            Write("Введите четвертое слово: ");
            string word_4 = ReadLine();
            Write("Введите пятое слово: ");
            string word_5 = ReadLine();
            WriteLine($"{word_1}{"!"}{word_1}{"!"}{word_3}{"!"}{word_3}{"!"}{word_5}{"!"}{word_5}{"!"}{word_2}{"!"}{word_2}{"!"}{word_2}{"!"}{word_4}{"!"}{word_4}{"!"}{word_4}");
            ReadKey();*/

            //Задача 2
            //Запросить у пользователя 5 слов, после чего вывести каждое слово на новой строке, при этом использовать 3 функции вывода.

            /*Title = "Программа№1 (Шурдук_Овчарук)";
            WriteLine("Введите 5 слов!");
            Write("Введите первое слово: ");
            string word_1 = ReadLine();
            Write("Введите второе слово: ");
            string word_2 = ReadLine();
            Write("Введите третье слово: ");
            string word_3 = ReadLine();
            Write("Введите четвертое слово: ");
            string word_4 = ReadLine();
            Write("Введите пятое слово: ");
            string word_5 = ReadLine();
            Write($"{word_1}\n{word_2}\n");
            WriteLine($"{word_3}");
            WriteLine($"{word_4}\n{word_5}");
            ReadKey();*/

            //Запросить через консоль имя пользователя, затем поздороваться с ним. Изменить цвет фона и символов. Установить название окна консоли в соответствии с именем пользователя. Отображать, включен ли CapsLock и NumLock. 

            /*SetWindowSize(50, 50);
            BackgroundColor = ConsoleColor.White;
            Clear();
            ForegroundColor = ConsoleColor.Black;
            WriteLine("Как тебя зовут?");
            string name = ReadLine();
            WriteLine($"Привет, {name}!");
            Title = name;
            CursorVisible = false;
            WriteLine("Caps Lock - " + (CapsLock ? "On" : "Off"));
            WriteLine("Num Lock - " + (NumberLock ? "On" : "Off"));*/

            ReadKey();
        }
    }
}
