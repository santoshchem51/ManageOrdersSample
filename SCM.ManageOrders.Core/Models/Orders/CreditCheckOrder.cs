using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM.ManageOrders.Core.Enumerators;
using SCM.ManageOrders.Core.Interfaces;
using SCM.ManageOrders.Core.Models.Base;

namespace SCM.ManageOrders.Core.Models
{
    public class CreditCheckOrder :  BaseOrder
    {
        public override ManageOrderEnums.eOrderTypes OrderType
        {
            get { return ManageOrderEnums.eOrderTypes.CreditCheck; } 
        }
    }
}
