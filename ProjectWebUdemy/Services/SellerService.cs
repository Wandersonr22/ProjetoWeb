using ProjectWebUdemy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebUdemy.Services
{
    public class SellerService
    {
        private readonly ProjectWebUdemyContext _context;

        public SellerService(ProjectWebUdemyContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }


    }
}
