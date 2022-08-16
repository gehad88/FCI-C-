using System;
namespace FCI_TEST
{
    partial class Worker : Employee
    {
        public Worker()
        {

        }

        public string WorkPlace { set; get; }
    }
    public partial class Worker                                // Methods
    {

        public override string ToString()
        {
            return "WORKER : \n\n"+ base.ToString()+"  , Salary : "+ Salary+"  ,  Work Place : "+WorkPlace+"\n\n"+"--------------------------------";
        }
        public override float calculateSalary()
        {
            return Salary - (AbsencesDay * 100);             //With each day of absence, the salary decreases by 100
        }

    }

}
