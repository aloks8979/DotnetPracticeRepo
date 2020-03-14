using System;

namespace DotNet_VS_Code
{
    class Program
    {
        static void Main(string[] args)
        {
            var student = new Student1("Alok");
            Console.WriteLine("Hello ! " +  student.GetName());

            //Object array
            var obj = new ArrayKuVenkat();
            var objArr = obj.GetArray();
            foreach(object o in objArr)
                System.Console.WriteLine("\n" + o);
            Console.WriteLine("Hello Man");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}