using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson1112
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 2");
            Rational rational = new Rational();
            Type typeInfo = typeof(Rational);
            object[] obj = typeInfo.GetCustomAttributes(false);
            Console.WriteLine((obj[0] as DeveloperInfoAttribute).dateTime);

            Console.WriteLine("Упражнение 1");
            Account account = new Account();
            account.DumpToScreen();

            Console.ReadKey();
        }
    }
}
