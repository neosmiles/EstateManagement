using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
  public class House
  {
    public int Id { get; set; }

    public int EstateId { get; set; }

    public int ResidentId { get; set; }

    // Relationship
    public ICollection<houseResident> houseResidents { get; set; }

    // Navigation
    public Estate Estate { get; set; }

    // public Resident Resident { get; set; }




  }
}