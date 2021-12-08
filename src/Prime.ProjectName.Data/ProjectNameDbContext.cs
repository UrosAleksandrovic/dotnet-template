using Microsoft.EntityFrameworkCore;

namespace Prime.ProjectName.Data
{
    public class ProjectNameDbContext : DbContext
    {
        public ProjectNameDbContext(DbContextOptions options) : base(options)
        {
        }
    }
}
