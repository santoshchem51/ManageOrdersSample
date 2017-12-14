using SCM.ManageOrders.Core.Enumerators;
using SCM.ManageOrders.Core.Models.Base;

namespace SCM.ManageOrders.Core.Models.Orders
{
    public class CriminalReportOrder : BaseOrder
    {
        public override ManageOrderEnums.eOrderTypes OrderType
        {
            get
            {
                return ManageOrderEnums.eOrderTypes.CriminalReport; 
            } 
        }
    }
}
