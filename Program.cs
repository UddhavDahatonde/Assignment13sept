using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13sept
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student=new Student();
            student.AssignValue();
            Console.WriteLine(student.DisplayValue ());
        }
    }
}
