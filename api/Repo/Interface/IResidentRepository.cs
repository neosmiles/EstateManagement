using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto.residentDto;
using api.Models;

namespace api.Repo.Interface
{
  public interface IResidentRepository
  {
    void add<T>(T entity) where T : class;
    void Delete<T>(T entity) where T : class;
    Task<bool> SaveAll();

    Task<Resident> AddResident(ResidentForcreation field);
    Task<IEnumerable<Resident>> GetResidents();
    Task<IEnumerable<object>> GetResidentWithId(int Id);
    Task<Resident> UpdateResident(ResidentForUpdate model);
    Task<bool> DeleteResident(int id);
  }
}