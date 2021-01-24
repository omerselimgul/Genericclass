using System;
using System.Collections.Generic;
using System.Text;

namespace oop1
{
    class productmanager
    {
        private List<product> Sanaldatabase = new List<product>();
        public void add(product pro)
        {
            Sanaldatabase.Add(pro);
            Console.WriteLine("Ürün Eklendi");
        }
        public void sayidegistirme(int sayi)
        {
            sayi = 100;
        }
        public void isimdegistirme(product pr)
        {
            pr.productname = "sandalye";
        }
        public void yazdirma()
        {
            foreach (var item in Sanaldatabase)
            {
                Console.WriteLine(item.productname);
            }
        }
    }
}
