using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM.ManageOrders.Core.Enumerators;

namespace SCM.ManageOrders.Core.Interfaces
{
    interface IOrderRepository
    {
        void AddNewOrder(int accountId, IOrder order, ManageOrderEnums.eOrderTypes orderType);

        List<IOrder> FetchAllOrders(int accountId);

        bool CancelAnOrder(int accountId, IOrder order);

        bool UpdateOrder(int accoutId, IOrder order);
    }
}
