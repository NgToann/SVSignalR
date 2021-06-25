using System.ComponentModel.DataAnnotations;

namespace SVSignalR.Shared.Models.MasterSchedule
{
    public class OutsoleSupplierModel
    {
        [Key]
        public int OutsoleSupplierId { get; set; }
        public string Name { get; set; }
        public string SupplierOperation { get; set; }
        public string Remarks { get; set; }
    }
}
