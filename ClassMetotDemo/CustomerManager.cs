﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Musteri listesi");
            Console.WriteLine("Musteri ID: " + customer.ID );
            Console.WriteLine("Musteri Adi: " + customer.Ad + " " + customer.SoyAd);
            Console.WriteLine("Musteri Telefon Numarasi: " + customer.TelefonNumarasi );
            Console.WriteLine("Musteri Anne Kizlik Soyadi: " + customer.AnneKizlikSoyadi);
            Console.WriteLine("************************************************");
        }
        public void Exterminate(Customer customer)
        {
            
            Console.WriteLine( customer.ID + " - " + customer.Ad + " " + customer.SoyAd + " - " + customer.TelefonNumarasi + " - " + customer.AnneKizlikSoyadi + "Kisisi silindi !" );
            Console.WriteLine("--------------------------------------------------");
        }
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.ID + " - " + customer.Ad + " " + customer.SoyAd + " - " + customer.TelefonNumarasi + " - " + customer.AnneKizlikSoyadi + "Kisisi basariyla kisilerin arasina eklendi !");
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++-");
        }

    }
}
