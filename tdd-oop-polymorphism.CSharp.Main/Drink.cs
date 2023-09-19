using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Drink : IProducts
    {
        //public int Id { get; set; }
        public string name { get; set; }
        public int price { get; set; }

        public Drink(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        public int getPrice()
        {
            return this.price;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
