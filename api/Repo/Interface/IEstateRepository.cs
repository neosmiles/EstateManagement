using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto.estateDto;
using api.Models;

namespace api.Repo.Interface
{
    public interface IEstateRepository
    {
         void add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveAll();

      Task<Estate> AddEstate(EstateForCreation field);
      Task<IEnumerable<Estate>> GetEstates();
      Task<IEnumerable<object>> GetEstateWithId(int Id);
      Task<Estate> UpdateEstate(EstateForUpdate model);
      Task <bool> DeleteEstate(int id);
    }
}