using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Ali";
            customer1.Surname = "Dagidir";
            customer1.TrId = "222222222";

            LegalEntityCustomer customer2 = new LegalEntityCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "2";
            customer2.CompanyName = "Dgdr";
            customer2.TaxNo = "1234567890";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new LegalEntityCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);


            //Real Person    -   Corporate
        }
    }
}
