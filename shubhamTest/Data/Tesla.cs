using shubhamTest.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shubhamTest.Data
{
  public  class Tesla
    {
        public IEnumerable<Cartest> LoadShops()
        {
            return new List<Cartest>
            {
                new Cartest("Mumbai", 10),
                new Cartest("Pune", 20),
                new Cartest("Nagpur", 30),
                new Cartest("Nashik", 40),
                new Cartest("Aurangabad", 50),
                new Cartest("Solapur", 60),
                new Cartest("Amravati", 70),
                new Cartest("Kolhapur", 80),
                new Cartest("Latur", 90),
                new Cartest("Sangli", 200)
            };
        }
    }
}
