using System;
namespace FCI_TEST
{
    public class Student : Person           //Define
    {
     
        public float Gpa { set; get; }
        public int Level { set; get; }
        public DEPARTMENT Department { set; get; }

        public override string ToString()
        {
            return "STUDENT : \n\n" + base.ToString() + "  ,  Gpa : " + Gpa + "  ,  Level : " + Level + "  ,  Department : "+Department.ToString()+ "\n\n" + "--------------------------------";
        }


    }
}
