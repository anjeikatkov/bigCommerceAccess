﻿namespace BigCommerceAccess.Models.Command
{
	internal class BigCommerceParam
	{
		public static readonly BigCommerceParam Unknown = new BigCommerceParam( string.Empty );
		public static readonly BigCommerceParam OrdersCreatedDateFrom = new BigCommerceParam( "min_date_created" );
		public static readonly BigCommerceParam OrdersCreatedDateTo = new BigCommerceParam( "max_date_created" );
		public static readonly BigCommerceParam OrdersModifiedDateFrom = new BigCommerceParam( "min_date_modified" );
		public static readonly BigCommerceParam OrdersModifiedDateTo = new BigCommerceParam( "max_date_modified" );

		private BigCommerceParam( string name )
		{
			this.Name = name;
		}

		public string Name { get; private set; }
	}
}