using ExpressoApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ExpressoApi.Data
{
    //inheriting ExpressoDbCobtext from the DbContext class in the EntityFramework package
    public class ExpressoDbContext:DbContext
    {
        //this property  will return the Dbset of menus and Reservations
        public DbSet<Menu> menus { get; set; }

        public DbSet<Reservation> reservations { get; set; }
    }
}