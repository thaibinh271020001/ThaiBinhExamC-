using System;

namespace TuLam6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nhan vien muon them");
            int n = Convert.ToInt32(Console.ReadLine());

            Company cp = new Company();

            cp.Success += new EmDelegate(cp.Succes);
            cp.ErrorInput += new EmDelegate(cp.Error);

            cp.Input(n);
        }
    }
}
