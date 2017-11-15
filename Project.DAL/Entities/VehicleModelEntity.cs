namespace Project.DAL.Entities
{
    public class VehicleModelEntity
    {
        #region Properties
        public int ID { get; set; }
        public int MakeId { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public virtual VehicleMakeEntity VehicleMake { get; set; }        
        #endregion Properties

    }

}
