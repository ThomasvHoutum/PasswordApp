using System;

namespace Domain.Models
{
    public class CreditCard
    {
        public string Issuer { get; private set; }
        
        public int Number { get; private set; }
        
        public DateTime ExpiryDate { get; private set; }
        
        public int Cvv { get; private set; }
        
        public string BillingAddress { get; private set; }

        public CreditCard(string issuer, int number, DateTime expiryDate, int cvv, string billingAddress)
        {
            Issuer = issuer;
            Number = number;
            ExpiryDate = expiryDate;
            Cvv = cvv;
            BillingAddress = billingAddress;
        }
    }
}