using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(d => d.Name).ToListAsync();
        }
    }
}
