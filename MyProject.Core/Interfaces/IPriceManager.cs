using MyProject.Core.Data;
using MyProject.Core.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Interfaces
{
    public interface IPriceManager
    {
        public void ApplyGlobalReduction(Order order, DiscountTypeEnum discountType, double discountValue);
        public void ApplySpecificReduction(Order order, OrderItem orderItem, DiscountTypeEnum type, double value);
    }
}
