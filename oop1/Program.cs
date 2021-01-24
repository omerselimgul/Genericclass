using System;

namespace oop1
{
    class Program
    {
        static void Main(string[] args)
        {
            product pr = new product();
            pr.Id = 1;
            pr.CategoryId = 2;
            pr.productname = "Masa";
            pr.unitinstock = 3;
            pr.unitprice = 500;

            product pr2 = new product {Id=2,CategoryId=5,unitinstock=5, productname="Kalem",unitprice=32 };

            productmanager pm = new productmanager();
            pm.add(pr);
            pm.add(pr2);
            pm.isimdegistirme(pr);

            pm.yazdirma();
            int sayi = 50;
            pm.sayidegistirme(sayi);
            Console.WriteLine(sayi);
            // ref Out 

        }
    }
}
