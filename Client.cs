using System;

namespace SojiTask
{
  class client
  {
      public void HasAccessTo()
      {
          Company newCompany = new Company();
          Console.WriteLine("Accessing the public Method of the company class.");
          newCompany.EnterreceptionOffice();
      }
  }
}