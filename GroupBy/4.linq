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

Orders
	//.GroupBy(X => X.SalesRep.FirstName + " " + X.SalesRep.LastName)
	.GroupBy(X => X.SalesRep)
	.Select(x => new
	{
		Sales = x.Key.FirstName + " " + x.Key.LastName
		Orders = x.Select(o => new
		{
			OrderID = o.OrderID,
			OrderData = o.OrderDate,
			Customer = o.Customer.CompanyName
		})
	})
	.Dump();