using System;
using System.Collections.Generic;
using System.Text;
namespace FCI_TEST
{
    public partial class FCI
    {
        public void largest3Salary()
        {
            for (int i = 0; i < persons.Count - 1; i++)
            {
                for (int j = i + 1; j < persons.Count; j++)
                {
                    if (persons[i] is Worker && persons[j] is Worker)
                    {
                        if (((Worker)persons[i]).Salary < ((Worker)persons[j]).Salary)
                            swap(persons, i, j);
                    }
                }
            }
            byte count = 0;
            for (int i = 0; i < persons.Count; i++)
            {
                if (persons[i] is Worker && count < 3)
                {
                    Console.WriteLine(persons[i].ToString());
                    count++;
                }

            }
        }
    }
}
