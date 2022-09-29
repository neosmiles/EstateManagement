using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {


    }
    public DbSet<Estate> Estates { get; set; }
    public DbSet<House> Houses { get; set; }
    public DbSet<Resident> Residents { get; set; }
    public DbSet<estateResident> estateResidents { get; set; }
    public DbSet<houseResident> HouseResidents { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.Entity<houseResident>().HasKey(hr => new { hr.HouseId, hr.ResidentId });

      modelBuilder.Entity<estateResident>().HasKey(er => new { er.EstateId, er.ResidentId });
    }





  }
}