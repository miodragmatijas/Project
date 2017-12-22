using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Views
{
    public class VehicleMakesView
    {
        #region Properties
        public int ID { get; set; }
         public string Name { get; set; }
         public string Abrv { get; set; }
        //public int countData { get; set; }

         ICollection<VehicleModelsView> VehicleModels { get; set; }
        #endregion Properties
    }

    public class VehiclePaged
    {
        public int CountData { get; set; }
        public IEnumerable<VehicleMakesView> VehicleMakesView { get; set; }
    }
}