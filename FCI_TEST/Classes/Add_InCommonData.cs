using System;
using System.Collections.Generic;
using System.Text;

namespace FCI_TEST
{
    public partial class FCI
    {
        bool checkIDConsistOfNums(string ID)
        {
            bool checkNum = true;
            if (ID.Length != 11)
                return false;
            for (int i = 0; i < ID.Length; i++)
            {
                checkNum = Char.IsNumber(ID[i]);
                if (!checkNum)
                    return false;
            }
            return true;

        }
        bool checkIdExistance(string id)
        {
            if (!checkIDConsistOfNums(id))
                return false;

            for (int i = 0; i < persons.Count; i++)
            {
                Person p = persons[i];
                if (p.ID == id)
                    return false;
            }
            return true;
        }

        private bool InCommonData(Person p)
        {
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age : ");
            bool checkAge = int.TryParse(Console.ReadLine(), out int age);
            if (age <= 0)
                checkAge = false;

            Console.WriteLine("Enter Id : ");
            string Id = Console.ReadLine();
            bool checkid = checkIdExistance(Id);

            Console.WriteLine("m : Male\nf : Female ");
            bool checkGender = true;
            string Gender = Console.ReadLine().ToLower();             //to make sure it is only f or m not F nor M
            if (Gender == "m")
                p.GENDER = GENDER.MALE;
            else if (Gender == "f")
                p.GENDER = GENDER.FEMALE;
            else
                checkGender = false;

            if(checkAge && checkid && checkGender)
            {
                p.Name = name;
                p.Age = age;
                p.ID = Id;
                return true;
            }
            return false;
        }

    }
}
