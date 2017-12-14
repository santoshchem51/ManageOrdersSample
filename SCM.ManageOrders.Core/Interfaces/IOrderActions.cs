using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM.ManageOrders.Core.Enumerators;

namespace SCM.ManageOrders.Core.Interfaces
{
    public interface IOrderActions 
    {
        List<IService> AddNewService(IService service);

        bool CancerOrder();

        bool SendToBilling();

        ManageOrderEnums.eOrderTypes OrderType { get; }
    }
}
