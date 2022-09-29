using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dto.estateDto;
using api.Models;
using api.Repo.Interface;
using Microsoft.EntityFrameworkCore;

namespace api.Repo
{
  public class EstateRepository : IEstateRepository
  {
    private readonly DataContext context;

    public EstateRepository(DataContext context)
    {
      this.context = context;
    }
    public void add<T>(T entity) where T : class
    {
      context.Add(entity);
    }

    public async Task<Estate> AddEstate(EstateForCreation field)
    {
      var data = new Estate

      {
        Name = field.Name,
        Address = field.Address
      };

      await context.Estates.AddAsync(data);
      await SaveAll();
      return data;
    }

    public void Delete<T>(T entity) where T : class
    {
      context.Remove(entity);
    }

    public async Task<bool> DeleteEstate(int id)
    {
      var dataFromRepo = await context.Houses.FirstOrDefaultAsync(a => a.Id == id);
      if (dataFromRepo != null)
      {
        context.Houses.Remove(dataFromRepo);
        await SaveAll();
        return true;
      }
      return false;
    }

    public async Task<IEnumerable<Estate>> GetEstates()
    {
      var dataFromRepo = await context.Estates.ToListAsync();
      return dataFromRepo;
    }

    public async Task<IEnumerable<object>> GetEstateWithId(int Id)
    {
      var dataFromRepo = await context.Estates.Where(x => x.Id == Id).ToListAsync();
      return dataFromRepo;
    }

    public async Task<bool> SaveAll()
    {
      return await context.SaveChangesAsync() > 0;
    }

    public async Task<Estate> UpdateEstate(EstateForUpdate model)
    {
      var data = await context.Estates.FirstOrDefaultAsync(i => i.Id == model.Id);
      if (data == null)
      {
        return null;
      };

      data.Id = model.Id;
      data.Name = model.Name;
      data.Address = model.Address;
      await SaveAll();

      return data;
    }
  }
}