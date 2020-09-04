using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace SalesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Birth date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Base salary")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double Salary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public ICollection<SaleRecord> Sales { get; set; } = new List<SaleRecord>();

        public Seller()
        {

        }

        public Seller(int id, string name, string email, DateTime birthDate, double salary, Department department)
        {
            Id = id;
            Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
            Salary = salary;
            Department = department;
        }

        public void addSales(SaleRecord sale) {
            Sales.Add(sale);
        }
        public void RemoveSales(SaleRecord sale)
        {
            Sales.Remove(sale);
        }
        public double TotalSales (DateTime initial, DateTime final)
        {
            return Sales.Where(x => (x.Date >= initial) && (x.Date<=final)).Sum(x=> x.Amount);
        }
    }
}
