using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingTest.Models;

namespace CodingTest.repository
{
    public class CoffeeRepository
    {
        //access only by methods
        private List<Coffee> _coffees = new List<Coffee>();

        public CoffeeRepository()
        {
            _coffees.Add(new Coffee("Black Coffe", "blk", 95));
            _coffees.Add(new Coffee("Espresso", "esp", 63));
            _coffees.Add(new Coffee("Cappuccino", "cap", 63));
            _coffees.Add(new Coffee("Latte", "lat", 63));
            _coffees.Add(new Coffee("Flat White", "wht", 63));
            _coffees.Add(new Coffee("Cold Brew", "cld", 120));
            _coffees.Add(new Coffee("Decaf Coffee", "dec", 5));
        }

        public List<Coffee> GetAll()
        {
            return new List<Coffee>(_coffees);
        }

        public Coffee GetByCode(string code)
        {
            return _coffees.FirstOrDefault(c => c.Code == code);
        }
    }
}