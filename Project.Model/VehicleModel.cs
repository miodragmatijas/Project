using Project.Model.Common;
using System.Runtime.Serialization;

namespace Project.Model
{
    [KnownType(typeof(VehicleModel))]
    public class VehicleModel : IVehicleModel
    {
        #region Properties
        public int ID { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }

        public virtual IVehicleMake VehicleMake { get; set; }
        #endregion Properties
    }
}
