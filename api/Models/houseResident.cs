using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
  public class houseResident
  {
    public int HouseId { get; set; }
    public House House { get; set; }

    public int ResidentId { get; set; }
    public Resident Resident { get; set; }



  }
}