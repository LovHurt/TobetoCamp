using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    public class CampaignManager : ICampaignService
    {
        public void Add()
        {
            Console.WriteLine("Campaign has been added");
        }

        public void Remove()
        {
            Console.WriteLine("Campaign has been removed");
        }

        public void Update()
        {
            Console.WriteLine("Campaign has been updated");
        }
    }
}
