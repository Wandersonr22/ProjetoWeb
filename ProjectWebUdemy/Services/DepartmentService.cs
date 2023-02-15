using ProjectWebUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebUdemy.Services
{
    public class DepartmentService
    {
        private readonly ProjectWebUdemyContext _context;

        public DepartmentService(ProjectWebUdemyContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
