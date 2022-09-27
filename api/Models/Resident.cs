using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Resident
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int EstateId { get; set; }

        public int HouseId { get; set; }


        
    }
}