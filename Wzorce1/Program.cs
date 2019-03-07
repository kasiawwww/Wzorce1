using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wzorce1.Builder.FileBuild;
using Wzorce1.Prototype;

namespace Wzorce1
{
    class Program
    {
        static void Main(string[] args)
        {
            //EmployeePrototype emp = new EmployeePrototype();
            //EmployeePrototype emp2 = emp.Clone();

            //emp2.Name = "kasia";
            //emp2.LastName = "WWW";
            //emp2.DailyHours = 8;
            //emp2.Holidays = 26;

            //Console.WriteLine(emp);
            //Console.WriteLine(emp2);


            //Console.WriteLine("zapisz jako txt");
            //var director = new Director(new TxtBuilder() { Path = "D:/test.txt" });
            //director.Construct("tekscik");
            //if (director.IsSuccess())
            //{
            //    Console.WriteLine("zapisano txt");
            //}

            //Console.WriteLine("zapisz jako csv");
            //var director1 = new Director(new CSVBuilder() { Path = "D:/test.csv" });
            //director1.Construct("tekscik testowy");
            //if (director1.IsSuccess())
            //{
            //    Console.WriteLine("zapisano csv");
            //}

            //Console.WriteLine("zapisz jako xml");
            //var director2 = new Director(new XMLBuilder() { Path = "D:/test.xml" });
            //director2.Construct("tekscik");
            //if (director2.IsSuccess())
            //{
            //    Console.WriteLine("zapisano xml");
            //}

            var xml_editor = AbstractFactory.AbstractFactory.GetFileEditor("D:/test.csv");
            xml_editor.Add("tescik kasia");
            Console.ReadKey(); 

        }
    }
}
