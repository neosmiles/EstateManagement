using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Data;
using api.Dto.residentDto;
using api.Models;
using api.Repo.Interface;
using Microsoft.EntityFrameworkCore;

namespace api.Repo
{
  public class ResidentRepository : IResidentRepository
  {
    private readonly DataContext context;

    public ResidentRepository(DataContext context)
    {
      this.context = context;
    }
    public void add<T>(T entity) where T : class
    {
      context.Add(entity);
    }

    public async Task<Resident> AddResident(ResidentForcreation field)
    {
      var data = new Resident

      {
        Name = field.Name,
        EstateId = field.EstateId,
        HouseId = field.HouseId
      };

      await context.Residents.AddAsync(data);
      await SaveAll();
      return data;

    }

    public void Delete<T>(T entity) where T : class
    {
      context.Remove(entity);

    }

    public async Task<bool> DeleteResident(int id)
    {
      var dataFromRepo = await context.Residents.FirstOrDefaultAsync(a => a.Id == id);
      if (dataFromRepo != null)
      {
        context.Residents.Remove(dataFromRepo);
        await SaveAll();
        return true;
      }
      return false;

    }

    public async Task<IEnumerable<Resident>> GetResidents()
    {
      var dataFromRepo = await context.Residents.ToListAsync();
      return dataFromRepo;


    }

    public async Task<IEnumerable<object>> GetResidentWithId(int Id)
    {
      var dataFromRepo = await context.Residents.Where(x => x.Id == Id).ToListAsync();
      return dataFromRepo;

    }

    public async Task<bool> SaveAll()
    {
      return await context.SaveChangesAsync() > 0;

    }

    public async Task<Resident> UpdateResident(ResidentForUpdate model)
    {
      var data = await context.Residents.FirstOrDefaultAsync(i => i.Name == model.Name);
      if (data == null)
      {
        return null;
      };

      data.Name = model.Name;
      data.EstateId = model.EstateId;
      data.HouseId = model.HouseId;
      await SaveAll();

      return data;

    }
  }
}