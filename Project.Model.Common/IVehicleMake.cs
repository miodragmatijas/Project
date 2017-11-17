using System.Collections.Generic;


namespace Project.Model.Common
{
   
    public interface IVehicleMake
    {
        #region Properties
        int ID { get; set; }
        string Name { get; set; }
        string Abrv { get; set; }

        ICollection<IVehicleModel> VehicleModels { get; set; }
        #endregion Properties
    }
}
