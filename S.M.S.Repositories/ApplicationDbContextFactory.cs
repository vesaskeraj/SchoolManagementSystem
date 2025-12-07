using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using S.M.S.Repositories;

public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        optionsBuilder.UseSqlServer("Server=.;Database=SMS;Trusted_Connection=True;TrustServerCertificate=True;");

        return new ApplicationDbContext(optionsBuilder.Options);
    }
}

