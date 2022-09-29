using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Estate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        public ICollection<House> Houses  { get; set; }

        public ICollection<estateResident> estateResidents  { get; set; }

        


    }
}