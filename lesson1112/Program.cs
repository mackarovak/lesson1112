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
            Rational rational = new Rational();
            Type typeInfo = typeof(Rational);
            object[] attrs = typeInfo.GetCustomAttributes(false);
            Console.WriteLine((attrs[0] as DeveloperInfoAttribute).dateTime);

            Account account = new Account();
            account.DumpToScreen();

            Console.ReadKey();
        }
    }
}
