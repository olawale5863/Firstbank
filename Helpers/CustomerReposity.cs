using CUSTOMER.Repository;
using FIRSTBANKOFNIGERIA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FIRSTBANKOFNIGERIA
{
    public class CustomerReposity : ICustomerRepository
    {
        public CustomerInformation GetCustomer(int Id)
        {
            CustomerInformation customerInformation = new CustomerInformation();

            return customerInformation;
        }
        public void Save(CustomerInformation customerInformation)
        {

        }
    }
}
