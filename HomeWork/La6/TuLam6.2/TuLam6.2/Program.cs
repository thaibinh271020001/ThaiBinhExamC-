using System;

namespace TuLam6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student();

            st.Id = 1;
            st.Name = "binh";
            Console.WriteLine("Nhap vao diem ly thuyet: ");
            st.Theorymark = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao diem thuc hanh: ");
            st.Labmark = Convert.ToDouble(Console.ReadLine());
            try
            {
                if (st.Theorymark < 0 || st.Theorymark > 10 || st.Labmark <0 || st.Labmark>10)
                {
                    throw new InvalidMarkException();
                }
            }
            catch(InvalidMarkException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
