<Query Kind="Expression">
  <Connection>
    <ID>5d05fc5b-6327-46b3-b2e9-dfcc6c0abe93</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://localhost:55881/api/v2/submitted</Server>
  </Connection>
</Query>

Packages.Where(
    p => (p.PackageValidationResultStatus == null || p.PackageValidationResultStatus == "Pending" || p.PackageValidationResultStatus == "Unknown")
)