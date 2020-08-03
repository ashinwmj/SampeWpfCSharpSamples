using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatterns.StrategyPattern
{
    public class Bill
    {
        public string CustomerName { get; set; }
        public CustomerType CustomerType { get; set; }
        public double BillAount { get; set; }

        private IDiscountStrategy _discountStrategy;



        public double GetFinalDiscountPrice()
        {
            switch (CustomerType)
            {
                case CustomerType.PremiumCustomer:
                     _discountStrategy = new PremiumDiscount();
                    break;
                case CustomerType.NonPremiumCustomer:
                    _discountStrategy=new NonPremiumDiscount();
                    break;
            }
           return _discountStrategy.GetDiscountedBillAount(BillAount);
        }


    }

    public class PremiumDiscount:IDiscountStrategy
    {
        public double GetDiscountedBillAount(double billAmount)
        {
            return billAmount * 0.5;
        }
    }
    public class NonPremiumDiscount : IDiscountStrategy
    {
        public double GetDiscountedBillAount(double billAmount)
        {
            return billAmount * 0.8;
        }
    }

    public interface IDiscountStrategy
    {
        double GetDiscountedBillAount(double billAmount);

    }

    public enum CustomerType
    {
        PremiumCustomer,
        NonPremiumCustomer
    }
}
