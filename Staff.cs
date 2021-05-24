using System;

namespace SojiTask
{
    class CompanyStaff : Company
    {
        public void HasAccessToCompany()
        {
            Company company = new Company();
            Console.WriteLine("Accessing both the Public and protected Methods of company class");
            company.EnterreceptionOffice();
            Console.WriteLine($"Can Staff Enter ManagersOffice : {EnterManagerOffice(true)}\nWith The Right Clearance");
        }
    }
}