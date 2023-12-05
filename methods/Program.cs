using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student(70, "John", 15);
            student1 student2 = new student1(40, "Tim", 10);

            Console.WriteLine(student1.IsObese());
            Console.WriteLine(student2.IsObese());

            Console.ReadLine();
        }
    }
}
