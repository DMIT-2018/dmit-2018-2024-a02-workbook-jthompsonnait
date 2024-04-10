<Query Kind="Statements">
  <Connection>
    <ID>d5faa15b-a6a1-43b6-9372-45c895891024</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <AllowDateOnlyTimeOnly>true</AllowDateOnlyTimeOnly>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook</Database>
    <DriverData>
      <LegacyMFA>false</LegacyMFA>
    </DriverData>
  </Connection>
</Query>

Albums
	.OrderBy( x=> x.ReleaseYear)
	.Select(x => x).Dump();

Albums
.GroupBy(x => x.ReleaseYear)
.Select(x => x).Dump();

