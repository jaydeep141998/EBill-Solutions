﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ElectricityBillingSystem.DTO
{
    public class CreateBillDTO
    {
        public double Units { get; set; }
        public DateTime DuePaymentDate { get; set; }
        public string PaymentStatus { get; set; }
        public long CustomerID { get; set; }

    }
}
