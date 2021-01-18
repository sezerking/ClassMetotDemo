using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.ID = 03795;
            customer1.Ad = "Mehmet";
            customer1.SoyAd = "Gursoy";
            customer1.TelefonNumarasi = 5698515428;
            customer1.AnneKizlikSoyadi = "Ak";

            Customer customer2 = new Customer();
            customer2.ID = 03856;
            customer2.Ad = "Fatma";
            customer2.SoyAd = "Kara";
            customer2.TelefonNumarasi = 5694236598;
            customer2.AnneKizlikSoyadi = "Gul";

            Customer customer3 = new Customer();
            customer3.ID = 04967;
            customer3.Ad = "Mert";
            customer3.SoyAd = "Yildirim";
            customer3.TelefonNumarasi = 5143698562;
            customer3.AnneKizlikSoyadi = "Aydin";

            Customer customer4 = new Customer();
            customer4.ID = 05138;
            customer4.Ad = "Adile";
            customer4.SoyAd = "Can";
            customer4.TelefonNumarasi = 5368465267;
            customer4.AnneKizlikSoyadi = "Ok";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4 };

            Console.WriteLine("-----------------------------Musteri Bilgileri----------------------------");

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerList(customer1);
            customerManager.CustomerList(customer2);
            customerManager.CustomerList(customer3);
            customerManager.CustomerList(customer4);
        }
    }
}
