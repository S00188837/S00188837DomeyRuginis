using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomasRuginisS00188837
{
    public class Phone
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Og_Image { get; set; }
        public string Phone_Image { get; set; }

        public virtual List<Phone> Phones { get; set; }

        double percentage;

        void IncreasePrice()
        {
            double priceToRaise;

            priceToRaise = (percentage / Price);

            Price = Price + priceToRaise;
        }
            
    }

    public class MyDataBase : DbContext
    {
        public MyDataBase() : base("MyPhoneData") { } 

        public DbSet<Phone> Phones { get; set; }
    }
}

    

