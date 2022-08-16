using System;
namespace FCI_TEST
{
    
    public partial class FCI
    {
        public void AddStudent()
        {
            Console.WriteLine("********** ADD STUDENT ********** ");

            Student s = new Student();
            bool check = InCommonData(s);
            
            Console.Write("\nEnter Gpa : ");
            bool checkGPA = float.TryParse(Console.ReadLine(), out float gpa);
            if (gpa > 4 || gpa < 0f)
                checkGPA = false;

            Console.Write("\nEnter Level : ");
            bool checklevel = int.TryParse(Console.ReadLine(), out int level);
            if (level < 1 || level > 4)
                checklevel = false;


            Console.Write("\nChoose between 1 and 5 \n01. CS \n02. IS\n03. IT \n04. MM\n\n Your Answer is : ");

            bool checkDepartment = int.TryParse(Console.ReadLine(), out int department);
            if (department == (int)DEPARTMENT.CS)
                s.Department = DEPARTMENT.CS;
            else if (department == (int)DEPARTMENT.IS)
                s.Department = DEPARTMENT.IS;
            else if (department == (int)DEPARTMENT.IT)
                s.Department = DEPARTMENT.IT;
            else if (department == (int)DEPARTMENT.MM)
                s.Department = DEPARTMENT.MM;
            else
                checkDepartment = false;

            if (check && checkGPA && checklevel && checkDepartment)
            {
                s.Gpa = gpa;
                s.Level = level;
                AddPerson(s);    //add to list 
            }
            else
                Console.WriteLine("\nInvalid Data !");

        }

    }
}
