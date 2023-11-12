using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICreditManager consumerCreditManager = new ConsumerCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>{new SmsLoggerService(), new FileLoggerService()}

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(vehicleCreditManager, fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {housingCreditManager, vehicleCreditManager };
           
            //applicationManager.DoCreditForeKnowledge(credits);

            Console.ReadLine();
        }
    }
}
