using SalesWebMvc.Models.Enums;
using System;



namespace SalesWebMvc.Models
{
    public class SalesRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus SaleStatus { get; set; }
        public Sellers Seller { get; set; }

       public SalesRecord()
        {

        }

        public SalesRecord(int id, DateTime date, double amount, SalesStatus saleStatus, Sellers seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatus = saleStatus;
            Seller = seller;
        }
    }
}
