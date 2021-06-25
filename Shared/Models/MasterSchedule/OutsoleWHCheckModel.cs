using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SVSignalR.Shared.Models.MasterSchedule
{
    public class OutsoleWHCheckModel
    {
        [Key]
        public int OSCheckingID { get; set; }
        public string WorkerId { get; set; }
        public string ProductNo { get; set; }
        public DateTime CheckingDate { get; set; }
        public int OutsoleSupplierId { get; set; }
        public string SizeNo { get; set; }
        public string SizeNoUpper { get; set; }
        public int Quantity { get; set; }
        public int Reject { get; set; }
        public int ReturnReject { get; set; }
        public int ReturnRemark { get; set; }
        public int ErrorId { get; set; }
        public int Excess { get; set; }
        public int WorkingCard { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsRelease { get; set; }
        public DateTime CreatedTime { get; set; }
        public Nullable<DateTime> UpdatedTime { get; set; }
        public Nullable<DateTime> ConfirmedTime { get; set; }
        public Nullable<DateTime> ReleasedTime { get; set; }

        [ForeignKey("ProductNo")]
        public OrderModel Order { get; set; }

        [ForeignKey("OutsoleSupplierId")]
        public OutsoleSupplierModel Supplier { get; set; }
    }
}
