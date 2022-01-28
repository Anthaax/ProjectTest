using MyProject.Data;
using MyProject.Enum;
using MyProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Manager
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

        public void CalculateTotalAmount(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
