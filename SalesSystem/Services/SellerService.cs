﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesSystem.Data;
using SalesSystem.Models;

namespace SalesSystem.Services
{
    public class SellerService
    {
        private readonly SalesSystemContext _context;

        public SellerService(SalesSystemContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller seller)
        {
            _context.Add(seller);
            _context.SaveChanges();
        }

        public Seller FindById(int id)
        {
            return _context.Seller.Include(s => s.Department).FirstOrDefault(s => s.Id == id);
        }

        public void Remove(int id)
        {
            var seller = _context.Seller.Find(id);
            _context.Seller.Remove(seller);
            _context.SaveChanges();
        }
    }
}
