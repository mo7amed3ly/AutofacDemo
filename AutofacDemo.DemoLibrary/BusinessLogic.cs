using AutofacDemo.DemoLibrary.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutofacDemo.DemoLibrary
{
    public class BusinessLogic : IBusinessLogic
    {
        private readonly ILogger logger;
        private readonly IDataAccess dataAccess;

        public BusinessLogic(ILogger logger, IDataAccess dataAccess)
        {
            this.logger = logger;
            this.dataAccess = dataAccess;
        }

        public void Process()
        {
            logger.Log("Started Processing data");
            dataAccess.GetData();
            dataAccess.SaveData("Business Logic data");
            logger.Log("Finished processing data");
        }
    }
}
