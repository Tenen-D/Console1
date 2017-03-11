using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("******Abra kadabra******");
            Console.WriteLine("Privet MIR");
            Console.WriteLine();

            // GetUserData();           // В этом методе програма использует данные введеные пользователем
            // MessBox();               // В этом методе открывается отдельное окно с надписью
            // TipesNew ();             // Метод в котором создаются типы переменних с помощю оператора "NEW"  со стандартным значением
            // TimeAndWatch();          // Операторы времени
            // StringMutki();           // Методы работы с текстом
            // StringBuilderMutki();    // StringBuilder более ресурсо-економный нежели string  
            nnn();


            Console.WriteLine();

            Console.ReadLine();


        }
        static void GetUserData()
        {

            Console.Write("Name: ");
            string _UName = Console.ReadLine();
            Console.WriteLine();
            Console.Write("age: ");
            string _age = Console.ReadLine();
            Console.WriteLine();


            ConsoleColor _Col = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Даровки {0} тебе {1} лет {2}", _UName, _age);
            Console.ForegroundColor = _Col;

        }
        static void MessBox()
        {
            string userMessage = string.Format("В этом методе открывается окно с этой надписью");
            System.Windows.MessageBox.Show(userMessage);
        }
        static void TipesNew()
        {
            Console.WriteLine("Метод в котором создаются типы переменних с помощю оператора \"NEW\" ");
            bool b = new bool();
            int i = new int();
            float f = new float();
            char ch = new char();
            DateTime DT = new DateTime();
            Console.WriteLine("b = {0} \ni = {1} \nf = {2} \nch = {3} \nDT = {4}", b, i, f, ch, DT);


        }
        static void TimeAndWatch()
        {
            Console.WriteLine("Операторы времени");
            DateTime vvv = new DateTime(0003, 02, 01, 04, 05, 06); // принимает (год,месяц,число и время)
            Console.WriteLine(vvv);
            Console.WriteLine();
            DateTime dt = new DateTime(2017, 03, 09); // принимает (год,месяц,число)
            TimeSpan ts = new TimeSpan(22, 36, 49); // принимает (время)
            DateTime tyt = dt + ts;
            Console.WriteLine("Дата написания этих строчек {0}. \nДень недели - {1}", tyt, dt.DayOfWeek);




        }
        static void StringMutki()
        {
            Console.Write("Введи свое имя жалкий смерд: \a");  //  \a - звуковой сигнал
            string _myName = Console.ReadLine();
            Console.WriteLine("И так {0}, вот что я тебе скажу ", _myName);
            Console.WriteLine("В твоем жалком имени {0} букв ", _myName.Length);
            Console.WriteLine("Если имя прокричать, то будет {0} ", _myName.ToUpper());
            Console.WriteLine("А если прошептать - {0} ! ", _myName.ToLower());
            Console.Write("Че зыриш? введи одну букву, а я посмотрю есть ли она в твоем именни: ");
        Vvod:
            Console.Write("\a");                                //  \a - звуковой сигнал
            string n = Console.ReadLine();
            if (_myName.Contains(n) == true)            //_myName.Contains(n) -етот метод проверяет есть ли в _myName указаная буква(ы)
            {
                Console.WriteLine("Да, есть такая буква!");
            }
            else
            {
                Console.Write("Обломись! Введи правильную букву: ");
                goto Vvod;

            }
            Console.WriteLine(_myName.Replace("q", "n"));            //меняет все буквы "q" на "n"

        }
        static void StringBuilderMutki()
        {

            Console.WriteLine("Тут показан метод вывода текста с помощю обекта StringBuilder. \nболее ресурсо-економного нежели string");
            Console.WriteLine();
            StringBuilder _s = new StringBuilder("КАРУСЕЛЬ");   // Добавляем новий обект StringBuilder, 
                                                                // и присваеваем ему начальное знаение "КАРУСЕЛЬ"

            _s.Append("\n");                                // с новой строки
            _s.AppendLine ("Карусель, карусель");              //  Добавляем в масив новую порцию букАв
            _s.AppendLine("Начинает разсказ");
            _s.AppendLine("Карусель, карусель");                // ||| AppendLine   | похоже |   WriteLine |||
            _s.AppendLine("Это радость для нас");               // |||   Append     |   на   |     Write   |||
            _s.Append("Прокатись на нашей карусели");
            Console.WriteLine(_s.ToString());
            Console.WriteLine("Всего в песенке {0} букв.", _s.Length);
            Console.WriteLine();
            _s.Replace("арусель", "окаин");                                              // (Replace) Заменяет все "арусель" на "окаин"
            _s.Replace("Прокатись на нашей карусели", "Занюхни ка вмести с нами");
            Console.WriteLine(_s.ToString());
            Console.WriteLine("Длинна песенки {0} символов", _s.Length);
        }
        static void nnn ()
        {
            
        }
        
    }
}
