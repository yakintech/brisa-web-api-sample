using System;
using Microsoft.EntityFrameworkCore;

namespace BrisaWebApiSample.Models.ORM
{
    public class BrisaContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=94.73.170.48; Database=dbBB8; UID=userBB8; PWD=HYp58-_c9hC7zF_-;TrustServerCertificate=true");

            //optionsBuilder.UseSqlServer("Server=/brisa; Database=dbBB8; Trusted_connection=true");
        }


        public DbSet<WebUser> WebUsers { get; set; }
    }
}


//add-migration createWebUserTable


//update-database

