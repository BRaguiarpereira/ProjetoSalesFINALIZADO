using ProjectSalesWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectSalesWeb.Services
{
    public class DepartmentService
    {
        private readonly ProjectSalesWebContext _context;
        public DepartmentService(ProjectSalesWebContext context)
        {
            _context = context;
        }
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
