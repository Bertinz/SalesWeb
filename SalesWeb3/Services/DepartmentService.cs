using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWeb3.Models;
using SalesWeb3.Data;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb3.Services
{
    public class DepartmentService
    {
        private readonly SalesWeb3Context _context;

        public DepartmentService(SalesWeb3Context context)
        {
            _context = context;
        }

        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
