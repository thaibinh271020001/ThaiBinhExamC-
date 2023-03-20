using System;
using System.Collections.Generic;
using System.Text;

namespace TuLam4._3
{
    class Document : IStoreabale,IEncryptable
    {
        public string Content { get; set; }
        
        public virtual void Read()
        {
            Console.WriteLine("Day la ham de Doc");
        }

        public virtual void Write()
        {
            Console.WriteLine("Day la ham de Luu");
        }

        public void Encrypt()
        {
            Console.WriteLine("Day la ham ma hoa");
        }

        public void Decrypt()
        {
            Console.WriteLine("Day la ham giai hoa");
        }
    }
}
