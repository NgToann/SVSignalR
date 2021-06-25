using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVSignalR.Shared.Models
{
    public class CovidPlanModel
    {
        [Key]
        [Required]
        public string WorkerId { get; set; }
        public int AddressId { get; set; }
        [ForeignKey("AddressId")]
        public virtual AddressModel AddressInfo { get; set; }
        public string FullName { get; set; }
        public string SectionName { get; set; }
        public string LineName { get; set; }
        public string PhoneNumber { get; set; }
        public string AddressDetail { get; set; }
        public string HealthStatus { get; set; }
        
        [NotMapped]
        public string AddressDisplay
        {
            get
            {
                if (AddressInfo != null)
                    return string.Format("{0} / {1} / {2}", AddressInfo.Commune, AddressInfo.District, AddressInfo.Province);
                else
                    return "";
            }
            set { }
        }

        public DateTime CreatedTime { get; set; }
    }
}
