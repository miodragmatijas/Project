using System;
using System.Collections.Generic;

namespace Project.DAL.Entities
{
    public class VehicleMakeEntity
    {
        #region Properties
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual ICollection<VehicleModelEntity> VehicleModels { get; set; }       
        #endregion Properties
    }

}
