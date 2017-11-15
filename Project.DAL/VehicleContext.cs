using System.Data.Entity;
using Project.Model.Common;
using Project.Model;

namespace Project.DAL
{
    public class VehicleContext : DbContext
    {
        public VehicleContext() : base("Vehicle")
        {
            Database.SetInitializer<VehicleContext>(new CreateDatabaseIfNotExists<VehicleContext>());;
        }

        public DbSet<VehicleMake> VehicleMakeEntities { get; set; }
        public DbSet<VehicleModel> VehicleModelsEntities { get; set; }

        
    }
}
