using FIRSTBANKOFNIGERIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CUSTOMER.Repository
{
    public interface ICustomerRepository
    {
        CustomerInformation GetCustomer(int Id);

        void Save(CustomerInformation customerInformation);
    }
}
