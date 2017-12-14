using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCM.ManageOrders.Core.Enumerators;
using SCM.ManageOrders.Core.Interfaces;
using SCM.ManageOrders.Core.Models.Base;

namespace SCM.ManageOrders.Core.Models.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private static OrderRepository _orderRepository;

        public static OrderRepository RepositoryInstace
        {
            get { return _orderRepository ?? (_orderRepository = new OrderRepository()); }
        }
        public void AddNewOrder(int accountId, IOrder order, ManageOrderEnums.eOrderTypes orderType)
        {
            throw new NotImplementedException();
        }

        public List<IOrder> FetchAllOrders(int accountId)
        {
            //throw new NotImplementedException();
            return new List<IOrder>
            {
                new BaseOrder()
                {
                    AccountNumber = 001,
                    CustomerName = "Test1",
                    OrderId = 001,
                    OrderServices = new List<IService>()
                    {
                        new Service()
                    }
                },
                new BaseOrder()
                {
                    AccountNumber = 002,
                    CustomerName = "Test2",
                    OrderId = 002,
                    OrderServices = new List<IService>()
                    {
                        new Service(),
                        new Service()
                    }
                }
            };
        }

        public bool CancelAnOrder(int accountId, IOrder order)
        {
            throw new NotImplementedException();
        }

        public bool UpdateOrder(int accoutId, IOrder order)
        {
            throw new NotImplementedException();
        }

        
    }
}
