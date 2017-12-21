using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM.ManageOrders.Core.Enumerators;


namespace SCM.ManageOrders.Core.Interfaces
{
    public interface IOrder
    {
        int OrderId { get; set; }
        string CustomerName { get; set; }
        int AccountNumber { get; set; }
        List<IService> OrderServices { get; set; } 


    }
}
