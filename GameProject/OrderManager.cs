using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class OrderManager
    {
        public void Add(ICampaignService campaignService)
        {
            Console.WriteLine("The new campaign has been added to you order");
        }

        public void Remove(ICampaignService campaignService)
        {
            Console.WriteLine("The campaign has been deleted from your order, We are so Sorry");
        }

      
    }
}
