using MyProject.Data;
using MyProject.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Interfaces
{
    public interface IPriceManager
    {
        public void CalculateTotalAmount(Order order);
        public void ApplyGlobalReduction(Order order, DiscountTypeEnum discountType, double discountValue);
        public void ApplySpecificReduction(Order order, OrderItem orderItem, DiscountTypeEnum type, double value);
    }
}
