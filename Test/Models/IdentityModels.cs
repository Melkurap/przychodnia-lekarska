using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace Test.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("PrzychodniaConnection")
        {
        }
        public DbSet<recepta> recepty { get; set; }
        public DbSet<skierowanie> skierowania { get; set; }
        public DbSet<Pacjent> pacjenci { get; set; }
        public DbSet<Lekarz> lekarze { get; set; }

//  public DbSet<KartaBadan> KartyBadan { get; set; }

    }
}