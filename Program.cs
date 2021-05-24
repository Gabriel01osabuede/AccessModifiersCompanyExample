using System;

namespace SojiTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            client myclient = new client();
            CompanyStaff companyStaff = new CompanyStaff();
            
            Console.WriteLine("Client");
            myclient.HasAccessTo();

            Console.WriteLine("");
            Console.WriteLine("Staff");
            companyStaff.HasAccessToCompany();
            //Console.WriteLine($" Staff Carry Manager Suit case : {companyStaff.carryManagerSuitCase()}");
            
            Console.WriteLine("");
            Console.WriteLine("Manager Accessing all levels");
            manager.EnterreceptionOffice();
            manager.HasAccessTo();
            manager.SuitCaseStatus();
            Console.WriteLine();

        }
    }
}
