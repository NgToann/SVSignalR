using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSignalR.Shared.Models.MasterSchedule
{
    public class OrderModel
    {
        [Key]
        public string ProductNo { get; set; }
        public string GTNPONo { get; set; }
        public string UCustomerCode { get; set; }
        public DateTime ETD { get; set; }
        public string ArticleNo { get; set; }
        public string ShoeName { get; set; }
        public int Quantity { get; set; }
        public string PatternNo { get; set; }
        public string MidsoleCode { get; set; }
        public string OutsoleCode { get; set; }
        public string LastCode { get; set; }
        public string Country { get; set; }
        public bool IsEnable { get; set; }
        public string Reviser { get; set; }

        public ICollection<SizeRunModel> SizeRuns { get; set; }
        //public Object SewingPlan { get; set; }
        //public Object AssemblyPlan { get; set; }
        //public Object OutsolePlan { get; set; }
        //public Object SockliningPlan { get; set; }
        //public ICollection<Object> RawMats { get; set; }
    }
}
