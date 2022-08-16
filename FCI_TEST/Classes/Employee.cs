using FCI_TEST;

namespace FCI_TEST
{
    public abstract partial class Employee : Person       //Define
    {
        public float Salary { set; get; }
        public float AbsencesDay { set; get; }

}

    abstract partial class Employee : Person             //Methods
    {
        abstract public float calculateSalary();

    }
}
