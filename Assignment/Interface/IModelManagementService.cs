using Assignment.Models;
using System;
using System.Collections.Generic;

namespace Assignment.Interface
{
    interface IModelManagementService
    {
        IList<Order_warehouse> MapOrdersToModel(IList<Business.Model.ORDER_WAREHOUSE> order_warehouse);
        Order_warehouse MapOrdersToModel(Business.Model.ORDER_WAREHOUSE order_warehouse);
        
    }
}
