<Query Kind="Expression">
  <Connection>
    <ID>a68a3849-5b2d-4ffb-9402-05ae70e117ee</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://chocolatey.org/api/v2</Server>
  </Connection>
</Query>

Packages.Where(
    pv => pv.IsLatestVersion
          && (pv.PackageTestResultStatusDate == null || pv.PackageTestResultStatusDate < DateTime.UtcNow.AddDays(-30) || pv.PackageTestResultStatus == "Pending")
          && pv.PackageTestResultStatus != "Exempted"
)