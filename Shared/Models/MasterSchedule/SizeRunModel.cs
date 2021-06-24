using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVSignalR.Shared.Models.MasterSchedule
{
    public class SizeRunModel
    {
        [Key]
        public int SizeRunId { get; set; }
        public string ProductNo { get; set; }
        public string OutsoleSize { get; set; }
        public string MidsoleSize { get; set; }
        public string LastSize { get; set; }
        public string SizeNo { get; set; }
        public int Quantity { get; set; }
        public bool UpdateOutsoleSizeByArticle { get; set; }

        public OrderModel Order { get; set; }
    }
}
