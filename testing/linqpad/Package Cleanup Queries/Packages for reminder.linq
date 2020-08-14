<Query Kind="Expression">
  <Connection>
    <ID>6a4fa768-8889-4bc9-9787-57092ae81689</ID>
    <Persist>true</Persist>
    <Driver>AstoriaAuto</Driver>
    <Server>http://chocolatey.org/api/v2/submitted</Server>
  </Connection>
</Query>

Packages.Where(
    p => p.Created < DateTime.UtcNow.AddDays(-20)
        && p.PackageStatus == "Submitted"
        && p.PackageSubmittedStatus == "Waiting"
        && (p.PackageCleanupResultDate == null)
        && ((p.PackageReviewedDate != null && p.PackageReviewedDate < DateTime.UtcNow.AddDays(-20)) 
            ||
            (p.PackageReviewedDate == null && p.PackageTestResultStatusDate < DateTime.UtcNow.AddDays(-20))
            )
)