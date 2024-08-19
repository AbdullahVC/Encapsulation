using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    class Araba
    {
        private int _kapıSayisi;
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        public int KapıSayisi
        {
            get { return _kapıSayisi; }
            set
            {
                // Eğer kapı sayısı 2 veya 4 değilse, uyarı ver ve -1 olarak ayarla
                if (value == 2 || value == 4)
                {
                    _kapıSayisi = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz Kapı Sayısı!");
                    _kapıSayisi = -1;
                }
            }
        }

        // Constructor
        public Araba(string marka, string model, string renk, int kapıSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapıSayisi = kapıSayisi; 
        }

        public void BilgileriGoster()
        {
            Console.WriteLine($"Marka: {Marka}, Model: {Model}, Renk: {Renk}, Kapı Sayısı: {KapıSayisi}");
        }
    }
}
