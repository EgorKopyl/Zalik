using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat
{
    class Order
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int Amount { get; set; }
        public List<OrderBoat> OrderBoat { get; set; }
        public List<Boat> Boats { get; set; }

    }
}
