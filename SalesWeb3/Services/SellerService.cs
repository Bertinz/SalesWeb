using SalesWeb3.Data;
using SalesWeb3.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWeb3.Services
{
    public class SellerService
    {
        private readonly SalesWeb3Context _context;

        public SellerService(SalesWeb3Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
