using System;

namespace Mau6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] a = new byte[5];

            try
            {
                for(int i =0; i <6; i++ ){
                    Console.Write("a[{0}] = " , i+1);
                    a[i] = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine();
                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Khong duoc nhap ki tu khong phu hop");
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Khong duoc nhap pham vi ngoai 0-255");
            }
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Khong duoc nhap ngoai pham vi cua mang");
            }

            for(int i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", a[i]);
            }
        }
    }
}
