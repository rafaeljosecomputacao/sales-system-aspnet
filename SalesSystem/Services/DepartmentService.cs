using System.Collections.Generic;
using System.Linq;
using SalesSystem.Data;
using SalesSystem.Models;

namespace SalesSystem.Services
{
    public class DepartmentService
    {
        private SalesSystemContext _context;

        public DepartmentService(SalesSystemContext context)
        {
            _context = context;
        }

        public List<Department> FindAll()
        {
            return _context.Department.OrderBy(d => d.Name).ToList();
        }
    }
}
