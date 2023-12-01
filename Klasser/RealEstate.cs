using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class RealEstate
    {
        public int Id { get; private set; }
        public string Address { get; set; }
        public int Rooms { get; set; }
        public int Area { get; set; }
        public int Price { get; set; }

        public RealEstate(string address, int id)
        {
                
        }
        public RealEstate()
        {
                
        }
        public override string ToString()
        {
            return Address;
        }

        public void AddId(int id)
        {
            Id = id;
        }
    }
}
