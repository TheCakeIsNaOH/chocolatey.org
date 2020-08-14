<Query Kind="Expression">
  <Connection>
    <ID>a68a3849-5b2d-4ffb-9402-05ae70e117ee</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://chocolatey.org/api/v2</Server>
  </Connection>
</Query>

Packages.Where(
	p => (p.IsLatestVersion || p.IsAbsoluteLatestVersion)
		&& (p.PackageScanStatus == null || p.PackageScanStatus == "Unknown" || p.PackageScanStatus == "Pending")
		&& ((p.PackageTestResultStatus == "Passing" || p.PackageTestResultStatus == "Exempted") ||
			(p.IsPrerelease && (p.PackageValidationResultStatus == "Failing") || p.PackageTestResultStatus == "Failing"))
)