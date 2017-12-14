using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM.ManageOrders.Core.Enumerators;
using SCM.ManageOrders.Core.Interfaces;

namespace SCM.ManageOrders.Core.Models.Base
{
    public class BaseOrder : IOrder,IOrderActions
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public int AccountNumber { get; set; }
        public List<IService> OrderServices { get; set; }
        public virtual List<IService> AddNewService(IService service)
        {
            throw new NotImplementedException();
        }

        public virtual bool CancerOrder()
        {
            throw new NotImplementedException();
        }

        public virtual bool SendToBilling()
        {
            throw new NotImplementedException();
        }

        public virtual ManageOrderEnums.eOrderTypes OrderType { get; }
    }
}
