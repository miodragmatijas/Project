using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Views
{
    public class VehicleModelView
    {
        public int ID { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual VehicleMakeView VehicleMake { get; set; }
    }
}