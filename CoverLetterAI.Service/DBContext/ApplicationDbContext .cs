using CoverLetterAI.Service.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoverLetterAI.Service.DBContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ApplicantProfile> ApplicantProfiles { get; set; }


    }
}
