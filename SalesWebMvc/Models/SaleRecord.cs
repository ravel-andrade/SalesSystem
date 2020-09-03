using SalesWebMvc.Models.Enums;
using System;



namespace SalesWebMvc.Models
{
    public class SaleRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalesStatus SaleStatus { get; set; }
        public Seller Seller { get; set; }

       public SaleRecord()
        {

        }

        public SaleRecord(int id, DateTime date, double amount, SalesStatus saleStatus, Seller seller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            SaleStatus = saleStatus;
            Seller = seller;
        }
    }
}
