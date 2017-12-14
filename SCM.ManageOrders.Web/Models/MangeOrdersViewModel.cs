using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SCM.ManageOrders.Web.Models
{
    public class MangeOrdersViewModel
    {

    }

    public class OrderDataModel
    {
        public int OrderId { get; set; }

        public int AccountId { get; set; }

        public string CustomerName { get; set; }

        public int ServiceCount { get; set; }
    }

}