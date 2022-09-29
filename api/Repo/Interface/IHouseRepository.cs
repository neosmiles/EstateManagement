using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dto.houseDto;
using api.Models;

namespace api.Repo.Interface
{
    public interface IHouseRepository
    {
        void add<T>(T entity) where T : class;
         void Delete<T>(T entity) where T : class;
         Task<bool> SaveAll();

      Task<House> AddHouse(HouseForCreation field);
      Task<IEnumerable<House>> GetHouses();
      Task<IEnumerable<object>> GetHouseWithId(int Id);
      Task<House> UpdateHouse(HouseForUpdate model);
      Task <bool> DeleteHouse(int id);
    }
}