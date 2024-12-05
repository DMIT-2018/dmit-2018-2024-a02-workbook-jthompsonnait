<Query Kind="Statements">
  <Connection>
    <ID>bed993b0-7186-4dbd-b3f2-30e1efaa4bc9</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>GroceryList</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

Products
.GroupBy(x => x.Category.Description)
.Select(x => new
{
	Categories = x.Key,
	Product = x.Select(p => new
	{
		ProductID = p.ProductID,
		ProductName = p.Description
	}).OrderBy(p => p.ProductName)
}).Dump();