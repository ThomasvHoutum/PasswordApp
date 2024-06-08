using System;
using Domain.Interfaces;
using Domain.LoginTypes;
using Domain.Results;

namespace Domain.Entities;

public class CreditCard : BankLogin, IAccountEntry
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
    
    public ValidationResult Validate()
    {
        if (string.IsNullOrEmpty(Issuer))
            return new ValidationResult(false, "Issuer is required");
        
        if (Number <= 0)
            return new ValidationResult(false, "Invalid number");
        
        if (Cvv <= 0)
            return new ValidationResult(false, "Invalid CVV");
        
        if (string.IsNullOrEmpty(BillingAddress))
            return new ValidationResult(false, "Billing address is required");
            
        return new ValidationResult(true);
    }
}