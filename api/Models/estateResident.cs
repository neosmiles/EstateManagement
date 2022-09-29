using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
  public class estateResident
  {
    public int EstateId { get; set; }

    public Estate Estate { get; set; }


    public int ResidentId { get; set; }
    public Resident Resident { get; set; }
  }
}