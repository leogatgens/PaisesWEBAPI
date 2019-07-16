
using Microsoft.EntityFrameworkCore;
using PaisesWEBAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaisesWEBAPI.Context
{
    public class TripsContext : DbContext
    {

        public TripsContext(DbContextOptions<TripsContext> options)
           : base(options)
        {


        }

        public DbSet<Country> Country { get; set; }

        public DbSet<Traveler> Traveler { get; set; }

        public DbSet<Trip> Trip { get; set; }

        public DbSet<FutureTrips> FutureTrips { get; set; }
    }
}
