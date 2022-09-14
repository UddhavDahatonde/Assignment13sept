using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13sept
{
    internal class Student
    {
        string name;
        int rollnumber, year;
        public void AssignValue()
        {
            name="Uddhav Dahatonde";
            rollnumber = 45;
            year = 2022;
        }
        public string DisplayValue()
        {
            return $" Student Information is:-> Name ===>{name} rollNumber is  {rollnumber}  year ==>{year}";
        }
    }
}
