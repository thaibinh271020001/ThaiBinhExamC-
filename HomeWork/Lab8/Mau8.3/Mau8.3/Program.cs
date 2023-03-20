using System;

namespace Mau8._3
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonalIdentification std = new PersonalIdentification("James Sandt");
            std.DateofBirth = new DateTime(2002, 12, 8);

            Employee<PersonalIdentification> empl = new Employee<PersonalIdentification>();

            empl.Identification = std;

            Console.WriteLine("Full name:      {0}", empl.Identification.FullName);
            Console.WriteLine("Date of birth:      {0}", empl.Identification.DateofBirth.ToShortDateString());
        }
    }
}
