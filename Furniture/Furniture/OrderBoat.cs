using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace boat
{
    class OrderBoat
    {
        [Key]
        public int Id { get; set; }

        public int BoatId { get; set; }
        public Boat Boat { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity { get; set; }

        public int Amount { get; set; }

    }
}
