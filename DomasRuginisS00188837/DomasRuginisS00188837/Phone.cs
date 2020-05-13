using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomasRuginisS00188837
{
    public class Phone
    {
        [Key]
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string Og_Image { get; set; }
        public string Phone_Image { get; set; }

        public Phone(string name, double price, string operatingsystem, string ogimage, string phoneimage)
        {
            Name = name;
            Price = price;
            OperatingSystem = operatingsystem;
            Og_Image = ogimage;
            Phone_Image = phoneimage;
        }

        

        public override string ToString()
        {
            return Og_Image + Name;
        }

        double percentage;

        void IncreasePrice()
        {
            double priceToRaise;

            priceToRaise = (percentage / Price);

            Price = Price + priceToRaise;
        }

    }

}

    

