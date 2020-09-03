using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace SalesWebMvc.Models
{
    public class Sellers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string email { get; set; }
        public DateTime birthDate { get; set; }
        public double Salary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>();

        public Sellers()
        {

        }

        public Sellers(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            this.email = email;
            this.birthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void addSales(SalesRecord sale) {
            Sales.Add(sale);
        }
        public void RemoveSales(SalesRecord sale)
        {
            Sales.Remove(sale);
        }
        public double TotalSales (DateTime initial, DateTime final)
        {
            return Sales.Where(x => (x.Date >= initial) && (x.Date<=final)).Sum(x=> x.Amount);
        }
    }
}
