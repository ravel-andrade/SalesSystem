﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Sellers> Sellers { get; set; } = new List<Sellers>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void addSaller(Sellers seller)
        {
            Sellers.Add(seller);
        }
        public double TotalSales(DateTime initial, DateTime final)
        {
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
