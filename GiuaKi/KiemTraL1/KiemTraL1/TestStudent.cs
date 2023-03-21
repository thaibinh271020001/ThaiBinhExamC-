using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTraL1
{
    class TestStudent
    {
        List<Student> testS = new List<Student>();
        

        public void Input()
        {
            Student st = new Student();
            Console.Write("Nhap vao id cua ban: ");
            st.Id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao Ten cua ban: ");
            st.Name = Console.ReadLine();
            Console.Write("Nhap vao gioi tinh cua ban(true/false): ");
            st.Gender = Convert.ToBoolean(Console.ReadLine());
            Console.Write("Nhap vao tuoi cua ban: ");
            st.Age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao ngay sinh cua ban: ");
            st.DateOfBirth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap vao lop cua ban: ");
            st.Class = Console.ReadLine();
            Console.Write("Nhap vao Diem thanh phan 1 cua ban: ");
            st.Mark1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao Diem thanh phan 2 cua ban: ");
            st.Mark2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap vao Diem thanh phan 3 cua ban: ");
            st.Mark3 = Convert.ToDouble(Console.ReadLine());

            testS.Add(st);
        }

        public void FindByName()
        {
            Console.Write("Nhap vao ten cua sinh vien muon tin: ");
            string findName = Console.ReadLine();

            foreach(Student st in testS)
            {
                if(st.Name == findName)
                {
                    Console.WriteLine(st);
                }
            }
        }

        public void Edit()
        {
            Console.WriteLine("Nhap id sinh vien muon sua thong tin: ");
            int inputId = Convert.ToInt32(Console.ReadLine());

            foreach(Student st in testS)
            {
                if (st.Id == inputId)
                {
                    testS.Remove(st);

                    st.Id = inputId;
                    Console.Write("Nhap vao Ten cua ban: ");
                    st.Name = Console.ReadLine();
                    Console.Write("Nhap vao gioi tinh cua ban(true/false): ");
                    st.Gender = Convert.ToBoolean(Console.ReadLine());
                    Console.Write("Nhap vao tuoi cua ban: ");
                    st.Age = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap vao ngay sinh cua ban: ");
                    st.DateOfBirth = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Nhap vao lop cua ban: ");
                    st.Class = Console.ReadLine();
                    Console.Write("Nhap vao Diem thanh phan 1 cua ban: ");
                    st.Mark1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap vao Diem thanh phan 2 cua ban: ");
                    st.Mark2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Nhap vao Diem thanh phan 3 cua ban: ");
                    st.Mark3 = Convert.ToDouble(Console.ReadLine());

                    testS.Add(st);
                }
            }
        }

        public void RemovebyID()
        {
            Console.Write("Nhap vao id muon xoa sinh vien: ");
            int removebyId = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testS.Count; i++)
            {
                Student st = testS[i];
                if (st.Id == removebyId)
                {
                    testS.Remove(st);
                }
            }
        }

        public void Sort()
        {
            testS.Sort();
            Console.WriteLine("Danh sach tang dan theo diem trung binh");

            foreach(var st in testS)
            {
                Console.WriteLine(st);
            }
        }

        public void Displayall()
        {
            foreach(var st in testS)
            {
                Console.WriteLine(st);
            }
        }
    }
}
