using System;
using FCI_TEST;
using System.Collections.Generic;

namespace FCI_TEST
{

    public partial class Program
    {
        static FCI fci = new FCI();

        static void Main(string[] args)
        {
            Menu();
        }
    }
    public partial class Program
    {
        public static void Menu()
        {
            Console.WriteLine("_______________________________\n01. To ADD ");
            Console.WriteLine("02. To Show ");
            Console.WriteLine("03. To Remove\n04. To Search\n[-1] To Exit\n_______________________________\n");
            Console.Write("your choice : ");
            bool checkChoice = short.TryParse(Console.ReadLine(), out short choice);
            if (choice == (short)OPTIONS.ADD)
            {
                Console.Write("---------------------------------\n01. To ADD Student\n02. To ADD Instructor\n03. TO ADD Worker\n04. Back" +
                    "\n---------------------------------\n your choice : ");
                bool checkChoice2 = short.TryParse(Console.ReadLine(), out short choice2);
                if (choice2 == (short)SUB_ADD.ADD_STUDENT)
                    fci.AddStudent();
                else if (choice2 == (short)SUB_ADD.ADD_WORKER)
                    fci.AddWorker();
                else if (choice2 == (short)SUB_ADD.ADD_INSTRUCTOR)
                    fci.AddInstructor();
                else if (choice2 == (short)SUB_ADD.BACK)
                    Menu();
                else
                    Console.WriteLine("\nInvalid Data !!");
                Menu();

            }
            else if (choice == (short)OPTIONS.SHOW)
            {
                Console.WriteLine("***************** SHOW *****************\n01. To Show All Members \n02. To Show Members in Alphabetical Order" +
              " \n03. TO Show All Students" + "\n04. To Show Male Instructor\n05. To Show First Student In Each Department\n06. To Show The Largest 3 Worker In Salary\n07. Back");
                bool checkChoice2 = short.TryParse(Console.ReadLine(), out short choice2);
                if (choice2 == (short)SUB_SHOW.SHOWALL)
                    fci.ShowAll();
                else if (choice2 == (short)SUB_SHOW.sortAlphabetical)
                    fci.sortAlphabetical();
                else if (choice2 == (short)SUB_SHOW.ShowStudent)
                    fci.ShowStudent();
                else if (choice2 == (short)SUB_SHOW.ShowMaleInstructor)
                    fci.ShowMaleInstructor();
                else if (choice2 == (short)SUB_SHOW.FirstRank)
                    fci.firstRank();
                else if (choice2 == (short)SUB_SHOW.largest3Salary)
                    fci.largest3Salary();
                else if (choice == (short)SUB_SHOW.BACK)
                    return;
            }
            else if (choice == (short)OPTIONS.REMOVE)
            {
                Console.Write("***************** REMOVE *****************\n");
                Console.Write("Enter ID : ");
                string Id = Console.ReadLine();
                fci.Remove(Id);
            }
            else if ((choice == (short)OPTIONS.SEARCH))
            {
                Console.WriteLine("Enter ID : ");
                string ID = Console.ReadLine();
                fci.Search(ID);
            }
            else if (choice == (short)OPTIONS.EXIT)
                return;
            else
                Console.WriteLine("\nInvalid Data !!");
            Menu();
        }

    }

}
