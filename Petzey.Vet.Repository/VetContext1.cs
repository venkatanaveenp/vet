using Petzey.Vet.Model;
using System;
using System.Data.Entity;
using System.Linq;

namespace Petzey.Vet.Repository
{
    public class VetContext1 : DbContext
    {
        // Your context has been configured to use a 'VetContext1' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Petzey.Vet.Repository.VetContext1' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'VetContext1' 
        // connection string in the application configuration file.
        public VetContext1()
            : base("name=VetContext1")
        {
        }
        public DbSet<Vets> Vets { get; set; }
        public DbSet<VetSchedule> Schedules { get; set; }
        public DbSet<VetContactInfo> Contacts { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}