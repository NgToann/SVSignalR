using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SVSignalR.Shared.Models
{
    public class AddressModel
    {
        [Key]
        public int AddressId { get; set; }
        public string Province { get; set; }
        public string ProvinceId { get; set; }
        public string District { get; set; }
        public string DistrictId { get; set; }
        public string Commune { get; set; }
        public string CommuneId { get; set; }
    }
}
