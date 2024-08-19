using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
            araba1.BilgileriGoster();

            Araba araba2 = new Araba("Honda", "Civic", "Siyah", 3);
            araba2.BilgileriGoster();
        }
    }
}