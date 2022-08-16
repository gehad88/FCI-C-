using System;
using System.Collections.Generic;
using System.Text;

namespace FCI_TEST
{
    public partial class FCI
    {
        public void AddWorker()
        {
            Console.WriteLine("********** ADD WORKER ********** ");

            Worker w = new Worker();
            bool check = InCommonData(w);


            Console.WriteLine("Enter Salary : ");
            bool checkSalary = float.TryParse(Console.ReadLine(), out float salary);
            if (salary < 0)
                checkSalary = false;


            Console.WriteLine("Enter Number of Absence Days : ");
            bool checkAbsenceDays = int.TryParse(Console.ReadLine(), out int AbsencesDays);
            if (AbsencesDays < 0)
                checkAbsenceDays = false;
                

            Console.WriteLine("Enter Work Place : ");
            string workPlace = Console.ReadLine();

            if(checkAbsenceDays && checkSalary)
            {
                w.Salary = salary;
                w.AbsencesDay = AbsencesDays;
                w.WorkPlace = workPlace;

                AddPerson(w);      // add to list
            }
            else
                Console.WriteLine("\nInvalid Data");


        }
    }
}
