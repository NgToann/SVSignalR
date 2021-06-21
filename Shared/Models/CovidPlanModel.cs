using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSignalR.Shared.Models
{
    public class CovidPlanModel
    {
        [Key]
        public string CovidPlanId { get; set; }
        [Required]
        public string WorkerId { get; set; }
        [NotMapped]
        public virtual WorkerModel WorkerInfo { get; set; }
        [NotMapped]
        public virtual AddressModel AddressInfo { get; set; }
        public int AddressId { get; set; }
        public string PhoneNumber { get; set; }        
        public string AddressDetail { get; set; }
        public string HealthStatus { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
