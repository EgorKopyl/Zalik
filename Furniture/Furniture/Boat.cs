using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace boat
{
    class Boat
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int TypeBoatId { get; set; }
        public TypeBoat TypeBoat { get; set; }
        public List<OrderBoat> OrderBoat { get; set; }
        public List<Order> Order { get; set; }
    }
}
