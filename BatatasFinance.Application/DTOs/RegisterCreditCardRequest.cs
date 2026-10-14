using BatatasFinance.Domain.Enums;

namespace BatatasFinance.Application.DTOs;

public record RegisterCreditCardRequest
{
        public required string Name { get; init; }
        public decimal CreditLimit { get ;  set; }
        public int ClosingDay { get ; set ; } 
        public int DueDay { get ; set ; }
        public CreditFlag CreditFlag { get ; init; }
};