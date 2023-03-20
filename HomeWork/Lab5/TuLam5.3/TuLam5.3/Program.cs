using System;

namespace TuLam5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            AnCo.Bo bo = new AnCo.Bo(1, "Bo`", 80);
            AnCo.Trau trau = new AnCo.Trau(2, "Trau`", 80);
            AnCo.De de = new AnCo.De(3, "De`", 80);

            Console.WriteLine("Infor dong vat an co");
            Console.WriteLine(bo.Id + "\t Name: " + bo.Name + "\t Weight: " + bo.Weight);
            Console.WriteLine(trau.Id + "\t Name: " + trau.Name + "\t Weight: " + trau.Weight);
            Console.WriteLine(de.Id + "\t Name: " + de.Name + "\t Weight: " + de.Weight);

            AnThit.CaSau casau = new AnThit.CaSau(1, "Ca Sau", 76);
            AnThit.Ho ho = new AnThit.Ho(2, "Ho", 76);
            AnThit.Sutu sutu = new AnThit.Sutu(3, "Su Tu", 76);

            Console.WriteLine("Infor dong vat an thit");
            Console.WriteLine(casau.Id + "\t Name: " + casau.Name + "\t Weight: " + casau.Weight);
            Console.WriteLine(ho.Id + "\t Name: " + ho.Name + "\t Weight: " + ho.Weight);
            Console.WriteLine(sutu.Id + "\t Name: " + sutu.Name + "\t Weight: " + sutu.Weight);
        }
    }
}

namespace AnCo
{
    public class Bo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public Bo(int id, string name, int weight)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
        }
    }
    public class Trau
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public Trau(int id, string name, int weight)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
        }
    }
    public class De
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public De(int id, string name, int weight)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
        }
    }
}
namespace AnThit
{
    public class CaSau
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public CaSau(int id, string name, int weight)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
        }
    }
    public class Ho
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }
        public Ho(int id, string name, int weight)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
        }
    }
    public class Sutu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Weight { get; set; }

        public Sutu(int id, string name, int weight)
        {
            this.Id = id;
            this.Name = name;
            this.Weight = weight;
        }
    }
}