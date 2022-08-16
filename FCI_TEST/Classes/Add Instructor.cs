using System;
using System.Collections.Generic;
using System.Text;

namespace FCI_TEST
{
    public partial class FCI
    {
        public void AddInstructor()
        {
            Console.WriteLine("********** ADD INSTRUCTOR ********** ");

            Instructor ins = new Instructor();
            bool check = InCommonData(ins);
          
            Console.WriteLine("Enter Salary : ");
            bool checkSalary = float.TryParse(Console.ReadLine(), out float salary);
            if (salary <= 0)
                checkSalary = false;


            Console.WriteLine("Enter Number of Absence Days : ");
            bool checkAbsenceDays = int.TryParse(Console.ReadLine(), out int AbsencesDays);
            if (AbsencesDays < 0)
                checkAbsenceDays = false;

            Console.WriteLine("Enter Subject : ");
            string subject = Console.ReadLine();
            ins.Subject = subject;

            if (checkAbsenceDays && checkSalary && check)
            {
                ins.Salary = salary;
                ins.AbsencesDay = AbsencesDays;
                AddPerson(ins);          //add to list 
            }
            else
                Console.WriteLine("\nInvalid Data");
           

        }
    }
}
