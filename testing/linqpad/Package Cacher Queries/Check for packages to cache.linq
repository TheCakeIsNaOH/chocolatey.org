<Query Kind="Expression">
  <Connection>
    <ID>a68a3849-5b2d-4ffb-9402-05ae70e117ee</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://chocolatey.org/api/v2</Server>
  </Connection>
</Query>

Packages.Where(
    p => (p.PackageStatus == "Approved" || p.PackageStatus == "Exempted")
      && (p.IsLatestVersion && p.PackageApprovedDate < DateTime.UtcNow.AddHours(-1) || (p.IsAbsoluteLatestVersion && p.IsPrerelease))
      && p.Created > DateTime.UtcNow.AddYears(-1)
      && (p.PackageTestResultStatus == "Passing" || p.PackageTestResultStatus == "Exempted")
      && p.DownloadCacheDate == null
      && p.Id != "chocolatey"
)
