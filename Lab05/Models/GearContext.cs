using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Lab05.Models
{
    public class GearContext : DbContext
    {        
        //GearContext inherits from DbContext a class that is part of the Microsoft Entity Framework.

        //Constructor for CarContext
        public GearContext(DbContextOptions<GearContext> options) : base(options)
        {



        }

        public DbSet<CharacterProgression> Charc { get; set; }


    }
}

