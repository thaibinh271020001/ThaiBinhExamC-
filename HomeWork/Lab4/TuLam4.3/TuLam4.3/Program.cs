using System;

namespace TuLam4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "long";

            Document dc = new Document();
            dc.Read();
            dc.Write();
            dc.Encrypt();
            dc.Decrypt();

            FileStream fs = new FileStream();
            fs.OpenFile(d);

            StreamReader sr = new StreamReader();
            sr.Read();

            StreamWriter sw = new StreamWriter();
            sw.Write();
        }
    }
}
