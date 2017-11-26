using Project.Model.Common;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Project.Model
{
    [KnownType(typeof(VehicleMake))]
    public class VehicleMake : IVehicleMake
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public  ICollection<IVehicleModel> VehicleModels { get; set; }
        #endregion Properties
    }
}
