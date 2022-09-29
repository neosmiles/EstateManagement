using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto.residentDto
{
  public class ResidentForUpdate
  {
    public string Name { get; set; }

    public int EstateId { get; set; }

    public int HouseId { get; set; }

  }
}