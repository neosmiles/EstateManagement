using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Dto.estateDto
{
  public class EstateForUpdate
  {
    public int Id { get; set; }

    public string Name { get; set; }
    public string Address { get; set; }
  }
}