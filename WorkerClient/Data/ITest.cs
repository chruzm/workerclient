using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WorkerClient.Models;

namespace Client.Data
{
    public interface ITest
    {
        Task<OrderObject> ReceiveOrdersAsync(int z);
    }
}