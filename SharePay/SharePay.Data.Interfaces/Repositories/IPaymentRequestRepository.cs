﻿using SharePay.Entities.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharePay.Data.Interfaces.Repositories
{
    public interface IPaymentRequestRepository : IRepository<PaymentRequest>
    {
        Task<IEnumerable<PaymentRequest>> GetActiveUserPaymentRequests(int userId);
    }
}
