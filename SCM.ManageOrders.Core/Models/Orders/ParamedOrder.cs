using SCM.ManageOrders.Core.Enumerators;
using SCM.ManageOrders.Core.Models.Base;

namespace SCM.ManageOrders.Core.Models.Orders
{
    public class ParamedOrder : BaseOrder
    {
        public override ManageOrderEnums.eOrderTypes OrderType
        {
            get { return ManageOrderEnums.eOrderTypes.Paramed; } 
        }

        public override bool CancerOrder()
        {
            // custom implementation for ParamedOrder
            return true;
        }
    }
}
