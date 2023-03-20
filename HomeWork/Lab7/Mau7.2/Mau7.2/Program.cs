using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Mau7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, string> listEm = new SortedList<string, string>();

            listEm.Add("E01", "Tran thi Thuy");
            listEm.Add("E02", "Dang Thai Binh");
            listEm.Add("E03", "Nguyen Khac Long");
            listEm.Add("E04", "Cao Viet Anh");
            listEm.Add("E05", "Chu Manh Thang");

            Console.WriteLine("danh sach nhan vien");
            /*foreach(string key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }*/

            Console.WriteLine("Danh sach cac nhan vien bat dau bang chu Th");
            foreach(string key in listEm.Keys)
            {
                if (listEm[key].StartsWith("Ca"))
                {
                    Console.WriteLine(key + ":" + listEm[key]);
                } 
            }

            listEm.Remove("E04");
            
            if (!listEm.ContainsKey("E06"))//kiem tra true false theo key
            {
                listEm.Add("E06", "Nguyen Ba Dat");
            }
            foreach (string key in listEm.Keys)
            {
                Console.WriteLine(key + ":" + listEm[key]);
            }
        }
    }
}
