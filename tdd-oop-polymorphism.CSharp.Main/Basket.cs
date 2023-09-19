using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_polymorphism.CSharp.Main
{
    public class Basket
    {
        List<IProducts> _products = new List<IProducts>();
        


        public void add(IProducts products)
        {
            _products.Add(products);
            
        }
        public void add(Game game)
        {
            this._products.Add(game);
        }

        public void add(Drink drink)
        {
            this._products.Add(drink);
        }

        public void add(Book book)
        {
            this._products.Add(book);
        }

        //public List<IProducts> isInBasket { get { return _products; } }

        public int getTotal()
        {
            int total = 0;

            return _products.Sum(x => x.price);

            //foreach (Game game in this.games)
            //{
            //    total += game.getPrice();
            //}

            //foreach (Drink drink in this.drinks)
            //{
            //    total += drink.getPrice();
            //}

            //foreach (Book book in this.books)
            //{
            //    total += book.getPrice();
            //}

            //return total;
        }



        public bool isInBasket(string name)
        {
            return _products.Any(x => x.name == name);
            //foreach (Game game in @this._products)
            //{
            //    if (game.getName().Equals(name))
            //    {
            //        return true;
            //    }
            //}

            //foreach (Drink drink in @this._products)
            //{
            //    if (drink.getName().Equals(name))
            //    {
            //        return true;
            //    }
            //}

            //foreach (Book book in @this._products)
            //{
            //    if (book.getName().Equals(name))
            //    {
            //        return true;
            //    }
            //}

            //return false;
        }
    }
}
