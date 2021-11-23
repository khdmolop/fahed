using System;

namespace ConsoleApp11overrloading
{
    class Program
    {
        static void Main(string[] args)
        {
            person p1 = new person();
            p1.print();
            p1.print(10);
            p1.print("khaled");
            p1.print(10, "khaled");
        }
    }
}
