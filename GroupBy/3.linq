<Query Kind="Statements">
  <Connection>
    <ID>8f5b5a94-75a5-4171-b34e-afaf7ed5feab</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>WestWind</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

//Customers
//	.GroupBy(c => c.Address.Region)
//	.Select(g => new
//	{
//	Region = g.Key == null ? "Unknown" : g.Key,
//	OrderCount = g.Sum(c => c.Orders.Count())
//	}).Dump();
//	
	OrderDetails
		.GroupBy(p => p.Product.ProductName)
		.Select(x => new 
		{
			Product = x.Key,
			TQ = x.Sum(x => x.Quantity),
			TS = x.Sum(x => x.Quantity * x.UnitPrice)
		}).Dump();