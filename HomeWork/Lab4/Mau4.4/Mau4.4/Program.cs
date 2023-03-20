using System;

namespace Mau4._4
{
    class Program
    {

        static void Main(string[] args)
        {
            IPerson staff = new Staff();
            object data = "Bach khoa Aptech";

            staff.Insert(data);
            staff.Delete(data);
            staff.Update(data);
            staff.Display(data);

            IPerson student = new Student()
            {
                Id = "S10",
                Name = "ChungLd",
                Age = 18
            };

            student.Display(student);
        }
    }
}
