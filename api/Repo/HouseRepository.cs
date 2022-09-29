using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dto.houseDto;
using api.Models;
using api.Repo.Interface;
using Microsoft.EntityFrameworkCore;

namespace api.Repo
{
  public class HouseRepository : IHouseRepository
  {
    private readonly DataContext context;

    public HouseRepository(DataContext context)
    {
      this.context = context;
    }
    public void add<T>(T entity) where T : class
    {
      context.Add(entity);
    }

    public async Task<House> AddHouse(HouseForCreation field)
    {
            var data = new House 

      {
        EstateId = field.EstateId,
        ResidentId = field.ResidentId
        };

        await context.Houses.AddAsync(data);
        await SaveAll();
        return data;

    }

    public void Delete<T>(T entity) where T : class
    {
      context.Remove(entity);
    }

    public async Task<bool> DeleteHouse(int id)
    {
      var dataFromRepo = await context.Houses.FirstOrDefaultAsync(a => a.Id == id);
      if(dataFromRepo != null)
      {
        context.Houses.Remove(dataFromRepo);
        await SaveAll();
        return true;
      }
      return false;
    }

    public async Task<IEnumerable<House>> GetHouses()
    {
      var dataFromRepo = await context.Houses.ToListAsync();
      return dataFromRepo;
    }

    public async Task<IEnumerable<object>> GetHouseWithId(int Id)
    {
      var dataFromRepo = await context.Houses.Where(x=> x.Id == Id).ToListAsync();
      return dataFromRepo;
    }

    public async Task<bool> SaveAll()
    {
      return await context.SaveChangesAsync() > 0;
      
    }

    public async Task<House> UpdateHouse(HouseForUpdate model)
    {
      var data = await context.Houses.FirstOrDefaultAsync(i => i.Id == model.Id);
      if(data == null)
      {
        return null;
      };

      data.Id = model.Id;
      data.EstateId = model.EstateId;
      data.ResidentId = model.ResidentId;
      await SaveAll();

      return data;
    }
  }
}