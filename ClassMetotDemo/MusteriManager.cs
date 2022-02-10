using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
       public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi"+musteri.Id);
        }

        public void Listele(Musteri[] musteri)
        {
            Console.WriteLine("Müşteri Listelendi");
            foreach (Musteri musteriler in musteri)
            {
                Console.WriteLine(musteriler.Id);
            }
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müşteri silinmiştir"+musteri.Id);
            
        }
        
    }
}
