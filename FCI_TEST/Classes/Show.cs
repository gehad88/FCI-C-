using System;
using System.Collections.Generic;
using System.Text;
namespace FCI_TEST
{
    public partial class FCI
    {
       
        public void sortAlphabetical()                            //You cannot access instance members from static members
        {
            for (int i = 0; i < persons.Count - 1; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                    if (persons[i].CompareTo(persons[j]) > 0)
                        swap(persons, i, j);
                
            }
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                Console.WriteLine(p.ToString());
            }
        }
        private void swap(List<Person> person, int i, int j)
        {
            Person p = person[i];
            person[i] = person[j];
            person[j] = p;
        }

        public void ShowStudent()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                if(p is Student)
                Console.WriteLine(p.ToString());
            }
        }
        public void ShowMaleInstructor()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                if (p is Instructor && ((Instructor)p).GENDER==GENDER.MALE)
                    Console.WriteLine(p.ToString());
            }
        }

    }
}
