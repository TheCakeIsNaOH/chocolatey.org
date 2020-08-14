<Query Kind="Expression">
  <Connection>
    <ID>5d05fc5b-6327-46b3-b2e9-dfcc6c0abe93</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://localhost:55881/api/v2/submitted</Server>
  </Connection>
</Query>

Packages.Where(
	pv => (pv.PackageTestResultStatus == null || pv.PackageTestResultStatus == "Pending" || pv.PackageTestResultStatus == "Unknown") &&
		  ((pv.PackageValidationResultStatus == "Passing" || pv.PackageValidationResultStatus == "Exempted") ||
		  (pv.IsPrerelease && pv.PackageValidationResultStatus == "Failing"))
)