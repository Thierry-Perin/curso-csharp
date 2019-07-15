using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities
{
    enum OrderStatus : int
    {
        PendinPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3
    }
}
