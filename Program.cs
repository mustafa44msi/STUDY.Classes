using System;

namespace classProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hoca hoca = new Hoca();
            Ogrenci ogrenci = new Ogrenci();
            Sinif sinif = new Sinif();

            Console.WriteLine("'1'Öğretmen \n'2'Öğrenci \n'3'Sınıf");
            int sorgu = Convert.ToInt32(Console.ReadLine());
            switch (sorgu) 
            {
                case 1:
                    for (int i = 0; i< hoca.dersler.Length; i++) { Console.WriteLine(hoca.dersler[i]); }
                    Console.WriteLine(hoca.dersSayisi);
                    break;
                case 2:
                    for (int i = 0; i < ogrenci.dersler.Length; i++) { Console.WriteLine(ogrenci.dersler[i]); }
                    Console.WriteLine(ogrenci.dersSayisi);
                    break;
                case 3:
                    for (int i = 0; i < sinif.dersler.Length; i++) { Console.WriteLine(sinif.dersler[i]); }
                    Console.WriteLine(sinif.dersSayisi);
                    break;



            }

            Console.WriteLine("Uygulamayı kapatmak için 'Enter' Tuşuna basın");
            Console.ReadLine();
        }
    }
}
