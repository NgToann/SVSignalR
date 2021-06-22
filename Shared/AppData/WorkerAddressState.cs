using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SVSignalR.Shared.Models;

namespace SVSignalR.Shared.AppData
{
    public class WorkerAddressState
    {
        public WorkerModel[] Workers { get; set; }
        public AddressModel[] Addresses { get; set; }
    }
}
