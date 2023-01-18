using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chest.Domain;
using Microsoft.EntityFrameworkCore;

namespace Chest.Domain.Interfaces
{
    public interface IChestDbContext
    {
       public DbSet<Chest> Chests {  get; set; }
       public DbSet<Stuff> Stuffs { get; set; }

    }

}

