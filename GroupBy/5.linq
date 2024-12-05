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

OrderDetails
	.GroupBy(x => x.Order.OrderDate.Value.Year)
	.Select(x => new
	{
		Year = x.Key,
		Revenue = x.Sum(o => o.Quantity * o.UnitPrice)
	}).Dump();