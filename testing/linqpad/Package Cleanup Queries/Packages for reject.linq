<Query Kind="Expression">
  <Connection>
    <ID>6a4fa768-8889-4bc9-9787-57092ae81689</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://chocolatey.org/api/v2/submitted</Server>
  </Connection>
</Query>

Packages.Where(
     p => p.PackageCleanupResultDate < DateTime.UtcNow.AddDays(-15)
         && p.PackageStatus == "Submitted"
         && p.PackageSubmittedStatus == "Waiting"
)