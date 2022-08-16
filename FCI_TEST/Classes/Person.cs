using System;
using System.Collections.Generic;
namespace FCI_TEST
{
    public abstract partial class Person : IComparable<Person>                 //Define
    {
       
        public string Name { get; set; }
        public int Age { get; set; }
        public string ID { get; set; }                            //readonly string ID
        public GENDER GENDER { get; set; }

    }
    public abstract partial class Person                      //Methods
    {
        public override string ToString()
        {
            return "Name : " + Name + "  ," + "  Age : " + Age + "  ," + "  ID : " + ID + "  ," + "  Gender : " + GENDER;
        }

        public static bool operator ==(Person p1, Person p2)
        {
            return p1.Name == p2.Name && p1.Age == p2.Age && p1.GENDER == p2.GENDER;
        }

        public static bool operator !=(Person p1, Person p2)
        {
            return p1.Name == p2.Name && p1.Age == p2.Age;
        }

        public int CompareTo(Person other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}



