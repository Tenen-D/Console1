using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console1
{
    class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("******Abra kadabra******");
            Console.WriteLine("Privet MIR");
            Console.WriteLine();

            // GetUserData();
            // MessBox();

            Console.WriteLine();

            Console.ReadLine();

            return -1;
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
            string userMessage = string.Format("100000 in hex is {0} ", 1000);
            System.Windows.MessageBox.Show(userMessage);
        }
    }
}
