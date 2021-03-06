﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BigCommerceAccess.Models.Order;

namespace BigCommerceAccess
{
	public interface IBigCommerceOrdersService
	{
		IEnumerable< BigCommerceOrder > GetOrders( DateTime dateFrom, DateTime dateTo );
		Task< IEnumerable< BigCommerceOrder > > GetOrdersAsync( DateTime dateFrom, DateTime dateTo );
	}
}