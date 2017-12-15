using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Views
{
    public class VehicleMakeView
    {
        #region Properties
        public int ID { get; set; }
         public string Name { get; set; }
         public string Abrv { get; set; }
        //public int countData { get; set; }

         ICollection<VehicleModelView> VehicleModels { get; set; }
        #endregion Properties
    }

    public class VehiclePaged
    {
        public int CountData { get; set; }
        public IEnumerable<VehicleMakeView> VehicleMakeView { get; set; }
    }
}