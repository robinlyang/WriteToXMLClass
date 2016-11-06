using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteToXMLClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Settings1 s = new Settings1();
            Console.WriteLine(s.worker);
            Console.WriteLine(s.salary);
            //changing salary
            s.salary = 90000;
            s.Save();

            Console.ReadLine();
        }
    }
}
