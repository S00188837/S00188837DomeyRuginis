using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using DomasRuginisS00188837;


namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDataBase db = new MyDataBase();

            using (db)
            {
                Phone p1 = new Phone("Samsung S20", 500, "Android", "/Images/android.png", "/Images/s20.jpg");
                Phone p2 = new Phone("iPhone11", 600, "IOS", "/Images/apple.png", "/Images/iphone11.png");

                db.Phones.Add(p1);
                db.Phones.Add(p2);

                Console.WriteLine("Added phones to Databse");

                db.SaveChanges();

                Console.WriteLine("Saved to databse");
            }
        }
    }
}
