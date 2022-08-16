using System;
using System.Collections.Generic;
using System.Text;

namespace FCI_TEST
{
    public partial class FCI
    {
        public void firstRank()
        {
            float MaxCs = 0f, MaxIS = 0f, MaxIT = 0f, MaxMM = 0f;
            string firstCs = "", firstIS = "", firstIT = "", firstMM = "";
            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                if (p is Student)
                {
                    if (((Student)p).Department == DEPARTMENT.CS)
                    {
                        if (((Student)p).Gpa > MaxCs)
                        {
                            firstCs = p.Name;
                            MaxCs = ((Student)p).Gpa;
                        }
                    }
                    else if (((Student)p).Department == DEPARTMENT.IS)
                    {
                        if (((Student)p).Gpa > MaxIS)
                        {
                            firstIS = p.Name;
                            MaxIS = ((Student)p).Gpa;
                        }
                    }
                    else if (((Student)p).Department == DEPARTMENT.IT)
                    {
                        if (((Student)p).Gpa > MaxIT)
                        {
                            firstIT = p.Name;
                            MaxIT = ((Student)p).Gpa;
                        }
                    }
                    else if (((Student)p).Department == DEPARTMENT.MM)
                    {
                        if (((Student)p).Gpa > MaxMM)
                        {
                            firstMM = p.Name;
                            MaxMM = ((Student)p).Gpa;
                        }
                    }
                }
            }

            Console.WriteLine("Student With First Rank In CS is : " + firstCs + " With GPA = " + MaxCs);
            Console.WriteLine("Student With First Rank In IS is : " + firstIS + " With GPA = " + MaxIS);
            Console.WriteLine("Student With First Rank In IT is : " + firstIT + " With GPA = " + MaxIT);
            Console.WriteLine("Student With First Rank In MM is : " + firstMM + " With GPA = " + MaxMM);

        }
    }
}
