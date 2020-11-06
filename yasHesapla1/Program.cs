using System;

namespace yasHesapla1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Doğum Tarihi Giriniz: ");
            int tarih = Convert.ToInt32(Console.ReadLine());
            int yas;
            yas = 2020 - tarih;
            Console.WriteLine(yas+" yaşındasın.");
            Console.ReadLine();
        }
    }
}
