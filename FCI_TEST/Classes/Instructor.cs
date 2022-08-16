using System.Collections.Generic;
using System;
namespace FCI_TEST
{
    public partial class Instructor : Employee                                //Define
    {
        public string Subject { set; get; }
    }
    partial class Instructor : Employee                                      //Methods
    {
        public override string ToString()
        {
            return "Instructor : \n\n" + base.ToString()+"  , Salary : "+Salary + "  , Subject : " + Subject + "\n\n" + "--------------------------------";
        }

        override public float calculateSalary()
        {
            return Salary - (AbsencesDay * 500);             //With each day of absence, the salary decreases by 500
        }
    }
}
