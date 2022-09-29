using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto.houseDto
{
  public class HouseForUpdate
  {
    public int Id { get; set; }

    public int EstateId { get; set; }

    public int ResidentId { get; set; }
  }
}