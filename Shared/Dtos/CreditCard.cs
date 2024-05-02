using System;

namespace Shared.Dtos;

public class CreditCard
{
    public string Issuer { get; private set; }
        
    public double Number { get; private set; }
        
    public DateTime ExpiryDate { get; private set; }
        
    public double Cvv { get; private set; }
        
    public string BillingAddress { get; private set; }

    public CreditCard(string issuer, double number, DateTime expiryDate, double cvv, string billingAddress)
    {
        Issuer = issuer;
        Number = number;
        ExpiryDate = expiryDate;
        Cvv = cvv;
        BillingAddress = billingAddress;
    }
}