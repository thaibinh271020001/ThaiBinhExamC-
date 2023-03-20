using System;

namespace Mau6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int intCnt;
            int intNum = 0;
            Console.WriteLine("Nhap 1 so");

            try
            {
                intNum = Convert.ToInt32(Console.ReadLine());

                if(intNum <= 0)
                {
                    throw new InvalidInputNumber();
                }
            }
            catch(InvalidInputNumber objInvalidInput)
            {
                Console.WriteLine(objInvalidInput.Message);
            }catch(FormatException objFormatException)
            {
                Console.WriteLine(objFormatException.Message);
            }
            finally
            {
                if (intNum > 0)
                {
                    for(intCnt = 1; intCnt <= 10; intCnt++)
                    {
                        Console.WriteLine(intNum*intCnt);
                    }
                }
            }
        }
    }
}
