using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Core.Data
{
    public abstract class BaseData
    {
        public BaseData(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
