<Query Kind="Expression">
  <Connection>
    <ID>5d05fc5b-6327-46b3-b2e9-dfcc6c0abe93</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://localhost:55881/api/v2/submitted</Server>
  </Connection>
</Query>

Packages.Where(
    p => (p.PackageStatus == "Submitted")
		&& (p.PackageScanStatus == null || p.PackageScanStatus == "Unknown" || p.PackageScanStatus == "Pending")
		&& ((p.PackageTestResultStatus == "Passing" || p.PackageTestResultStatus == "Exempted") ||
			(p.IsPrerelease && (p.PackageValidationResultStatus == "Failing") || p.PackageTestResultStatus == "Failing"))
)