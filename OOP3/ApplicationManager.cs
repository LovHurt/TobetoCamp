using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    public class ApplicationManager
    {
        //Method Injection

        public void Apply(ICreditManager creditManager, ILoggerService XLoggerService, ILoggerService YLoggerService, ILoggerService ZLoggerService)
        {
            creditManager.Calculate();
            XLoggerService.Log();
            YLoggerService.Log();
            ZLoggerService.Log();
        }

        public void DoCreditForeKnowledge(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
