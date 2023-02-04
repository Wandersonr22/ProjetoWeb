using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectWebUdemy.Models
{
    public class ProjectWebUdemyContext : DbContext
    {
        public ProjectWebUdemyContext (DbContextOptions<ProjectWebUdemyContext> options)
            : base(options)
        {
        }

        public DbSet<ProjectWebUdemy.Models.Department> Department { get; set; }
    }
}
