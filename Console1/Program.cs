using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            // TipesNew ();             // Метод в котором создаются типы переменних с помощю оператора "NEW"

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
            Console.WriteLine("Даровки {0} тебе {1} лет {2}",  _UName, _age);
            Console.ForegroundColor = _Col;

        }
        static void MessBox()
        {
            string userMessage = string.Format("В этом методе открывается окно с этой надписью");
            System.Windows.MessageBox.Show(userMessage);
        }
        static void TipesNew ()
        {
            Console.WriteLine("Метод в котором создаются типы переменних с помощю оператора \"NEW\" ");
            bool b = new bool();
            int i = new int();
            float f = new float();
            char ch = new char();
            DateTime DT = new DateTime();
            Console.WriteLine("b = {0} \ni = {1} \nf = {2} \nch = {3} \nDT = {4}",b,i,f,ch,DT);


        }
    }
}
