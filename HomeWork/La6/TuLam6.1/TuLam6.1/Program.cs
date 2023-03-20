using System;

namespace TuLam6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Object ob = new object();
            int a;

            int[] b = {1,2,3,4 };
            /*try
            {
                Console.WriteLine(b[5]);
                a = (int)ob;
                Console.WriteLine(a);
            }
            catch(InvalidCastException ex)
            {
                Console.WriteLine("tran");
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }*/

            string[] st1 = { "mot", "hai", "ba"};
            object[] st2 = st1;

            try
            {
                st2[0] = 5;
            }
            catch(ArrayTypeMismatchException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
