using System;
using System.Collections.Generic;
using System.Text;

namespace FCI_TEST
{
    public partial class FCI
    {
        private List<Person> persons = new List<Person>();
        public FCI()
        {
            FakeData();
        }
        private void AddPerson(Person p)
        {
            persons.Add(p);
            Console.WriteLine("Done ..\n\n");
        }
        public void ShowAll()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                Console.WriteLine(p.ToString());
            }
        }

        public void Remove(string ID)              //edit this fuction to bool instead of void to make sure Id is already exist in list and has been removed
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                if (p.ID.CompareTo(ID) == 0)
                {
                    persons.RemoveAt(i);
                    Console.WriteLine("Done ..\n\n");
                }
            }
        }

        public void Search(string ID)                       //serach for peson
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];                            // we can add condtiton about null value if    (!(p[i] is null)
                if (p.ID.CompareTo(ID) == 0)
                    Console.WriteLine(p.ToString());
            }
        }

        public void FakeData()
        {
            List<Person> p = new List<Person>(){
                new Student{Name = "Zaid", Age= 25,ID= "12312312312",GENDER = GENDER.FEMALE,Gpa =3.0f, Department= DEPARTMENT.IT, Level = 2},
                new Student{Name = "Ahmed", Age= 23,ID= "68968968968",GENDER = GENDER.FEMALE,Gpa =2.5f, Department= DEPARTMENT.IS, Level = 3},
                new Student{Name = "lio", Age= 32,ID= "23523523523",GENDER = GENDER.FEMALE,Gpa =4.0f, Department= DEPARTMENT.IS, Level = 4},
                new Student{Name = "reem", Age= 29,ID= "47647647647",GENDER = GENDER.FEMALE,Gpa =3.5f, Department= DEPARTMENT.CS, Level = 1},
                new Student{Name = "nada", Age= 28,ID= "65465465465",GENDER = GENDER.FEMALE,Gpa =2.0f, Department= DEPARTMENT.MM, Level = 3},
                new Student{Name = "maram", Age= 36,ID= "239239239239",GENDER = GENDER.FEMALE,Gpa =1.5f, Department= DEPARTMENT.CS, Level = 2},
                new Worker{ Name = "Worker1", Age =30, ID = "61261261261", GENDER = GENDER.FEMALE, WorkPlace = "area139", Salary = 2500 },
                new Worker{ Name = "Worker2", Age =31, ID = "32532532532", GENDER = GENDER.MALE, WorkPlace = "area139", Salary = 3500 },
                new Worker{ Name = "Worker3", Age =36, ID = "45845845845", GENDER = GENDER.FEMALE, WorkPlace = "area139", Salary = 5150 },
                new Worker{ Name = "Worker4", Age =40, ID = "197", GENDER = GENDER.MALE, WorkPlace = "area139", Salary = 6320 },
                new Worker{ Name = "Worker5", Age =45, ID = "163", GENDER = GENDER.MALE, WorkPlace = "area139", Salary = 2150 },
                new Worker{ Name = "Worker6", Age =50, ID = "267", GENDER = GENDER.MALE, WorkPlace = "area139", Salary = 9150 },
                new Worker{ Name = "Worker7", Age =65, ID = "258", GENDER = GENDER.FEMALE, WorkPlace = "area139", Salary = 2150 },
                new Instructor{Name = "ins1" , Age = 63 , ID = "497" , GENDER = GENDER.MALE, Subject =  "Data Structure", Salary = 2650, AbsencesDay = 5},
                new Instructor{Name = "ins2" , Age = 55 , ID = "329" , GENDER = GENDER.FEMALE, Subject =  "Data Base", Salary = 2730, AbsencesDay = 4},
                new Instructor{Name = "ins3" , Age = 50 , ID = "159" , GENDER = GENDER.MALE, Subject =  "System Analysis", Salary = 5065, AbsencesDay = 3},
                new Instructor{Name = "ins4" , Age = 45 , ID = "357" , GENDER = GENDER.FEMALE, Subject =  "OOP", Salary = 1422, AbsencesDay = 5},
                new Instructor{Name = "ins5" , Age = 48 , ID = "753" , GENDER = GENDER.MALE, Subject =  "Data Communication", Salary = 6650, AbsencesDay = 8},
                new Instructor{Name = "ins6" , Age = 69 , ID = "823" , GENDER = GENDER.MALE, Subject =  "Math 3", Salary = 4320, AbsencesDay = 6}

             };
            persons.AddRange(p);

        }
    }
}
