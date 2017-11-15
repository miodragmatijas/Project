namespace Project.Model.Common
{
    public interface IVehicleModel
    {
        #region Properties
         int ID { get; set; }
         int MakeId { get; set; }
         string Name { get; set; }
         string Abrv { get; set; }

         IVehicleMake VehicleMake { get; set; }
        #endregion Properties
    }
}
