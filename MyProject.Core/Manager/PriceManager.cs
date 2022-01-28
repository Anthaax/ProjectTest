using MyProject.Core.Data;
using MyProject.Core.Enum;
using MyProject.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Manager
{
    public class PriceManager : IPriceManager
    {
        public void ApplyGlobalReduction(Order order, DiscountTypeEnum discountType, double discountValue)
        {
            throw new NotImplementedException();
        }

        public void ApplySpecificReduction(Order order, OrderItem orderItem, DiscountTypeEnum type, double value)
        {
            throw new NotImplementedException();
        }
    }
}
