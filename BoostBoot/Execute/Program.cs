using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Driver;
using NewBoot;
using OldBoot;

namespace Execute
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Driver.DriverFactroy newDriver = new DriverFactroy(@"C:\sel");
            // NewBoot.BussinesLogic newbl = new BussinesLogic(newDriver.Create());

            // newbl.Start();

            Driver.DriverFactroy oldDriver = new DriverFactroy(@"C:\sel");
            OldBoot.BusinessLogic oldbl = new BusinessLogic(oldDriver.Create());

            oldbl.Start();

        }
    }
}
