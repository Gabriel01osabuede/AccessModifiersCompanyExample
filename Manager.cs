using System;

namespace SojiTask
 {
     class Manager : Company
     {
        private string managerSuitCase {get; set;}

        public void SuitCaseStatus()
        {
           Console.WriteLine(OpenManagerSuitCase() + " : " + true);
        }

        private string OpenManagerSuitCase()
        {
            string status = "Manager Open his suitCase";
            return status;
        }
         public void HasAccessTo()
         {
            Console.WriteLine($"Manager Has Access to is office : {EnterManagerOffice(true)}");
         }         
     }
 }