using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SCM.ManageOrders.Core.Models.Repository;
using SCM.ManageOrders.Web.Models;

namespace SCM.ManageOrders.Web.Controllers
{
    public class ManageOrdersController : Controller
    {
        // GET: ManageOrders
        public ActionResult ManageOrders()
        {
            return View();
        }

        public ActionResult GetAllOrders()
        {
            var ordersFromRepository = OrderRepository.RepositoryInstace.FetchAllOrders(123);
            if (ordersFromRepository != null)
            {
                return PartialView("OrderList", ordersFromRepository.Select(x => new OrderDataModel()
                {
                    AccountId = x.AccountNumber,
                    CustomerName = x.CustomerName,
                    OrderId = x.OrderId,
                    ServiceCount = x.OrderServices?.Count ?? 0
                }));
            }
            else
            {
                return PartialView("OrderList", new List<OrderDataModel>());
            }
        }
    }
}