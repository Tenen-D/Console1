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
            //                          ЧАСТЬ1
            // GetUserData();           // В этом методе програма использует данные введеные пользователем
            // MessBox();               // В этом методе открывается отдельное окно с надписью
            // TipesNew ();             // Метод в котором создаются типы переменних с помощю оператора "NEW"  со стандартным значением
            // TimeAndWatch();          // Операторы времени
            // StringMutki();           // Методы работы с текстом
            // StringBuilderMutki();    // StringBuilder более ресурсо-економный нежели string  
            // Tsikli();                // Тут описаны 4 вида циклов (for, foreach, while, do/while)
            OperVarianti();          // Операторы (if/else и switch) - Операторы ветвления ("возможные варианты поведения кода") 

            Console.WriteLine("exit");

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
            _s.Replace("Прокатись на нашей карусели", "Занюхни ка вместе с нами");
            Console.WriteLine(_s.ToString());
            Console.WriteLine("Длинна песенки {0} символов", _s.Length);
        }
        static void Tsikli()
        {

            Console.WriteLine("\t\tЦикл for ");
            Console.WriteLine("Введи цыфру, и полуишь ее квадрат и куб");
           
            string o = Console.ReadLine();
            int z = int.Parse(o);
            int p = z;
            Console.WriteLine("цыфра\tквадрат\tкуб");
            Console.Write(p);
            for (int i = 0; i < 2; i++)
            {
                p = z * p;
                Console.Write("\t{0}",p);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\tЦикл foreach");
            string[] ii = { "камень", "вино","дерево", "метал" }; //Создаем масив
            Console.WriteLine("{0} {1} {2} {3}",ii);
            
            foreach (string m in ii)                                     
            {
               
                Console.WriteLine(m);                               //Выводим поочередно значения масива на экран
            }
            Console.WriteLine();
            Console.WriteLine(); 
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\tЦикл while");
            bool n = false;
            int b = 0;
            string a = "password";
            while(n == false || b < 1)                          //Цикл будет повторятся пока не будет нарушено одно из условий
            {
                Console.WriteLine("Vvedite password");
                string m = Console.ReadLine();
                if (m == a)
                {
                    n = true;
                    b += 1;
                }
                else
                {
                    Console.WriteLine("Oshibka");
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\t\tНиже представлен цикл do/while, котороый розоблачает тебя");
            string mm;
            do
            {
                Console.WriteLine("You a gay?");
                 mm = Console.ReadLine();
            }
            while( mm != "yes");
            
            Console.WriteLine("ха ха ха");
        }
        static void OperVarianti()
        {
            //Оператор if/else
            V1:
            Console.WriteLine("Ты черепашка ниндзя?\ny-да \nn-нет");
            string otvet = Console.ReadLine();
            if(otvet == "y")
            {
                Console.WriteLine("Вот и молодец");
            }
            else if (otvet =="n")
            {
                Console.WriteLine("А, ты и з этих, телепузиков...");
            }
            else
            {
                Console.WriteLine("Ты думаеш я тут шутки шучу? Отвечай на вопрос!");
                Console.WriteLine();
                goto V1;
            }
            Console.WriteLine();

            // Оператор switch
            PoftorVoprosa:
            ConsoleColor defolt_Color = Console.ForegroundColor;        //запоминаем изначальный цвет текста
            Console.WriteLine("синий, желтый или зеленый?");
            string q = Console.ReadLine();
            switch (q)
            {
                case "синий":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "желтый":

                    Console.ForegroundColor = ConsoleColor.Yellow;
                        break;
                case "зеленый":
                    
                    Console.ForegroundColor = ConsoleColor.Green;
                        break;
                default:
                    Console.WriteLine("Тебе задали вопрос!!!");
                    goto PoftorVoprosa;                    
            }
            Console.WriteLine("Хорошый цвет, мне нравится");
            Console.ForegroundColor = defolt_Color ;                         //возвращяем изначальный цвет текста
        }        
    }
}
