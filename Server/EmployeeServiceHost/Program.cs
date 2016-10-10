using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost employeeServiceHost = new ServiceHost(typeof(EmployeeService.EmployeeService)))
            {
                // ServiceHost personalServiceHost = new ServiceHost(typeof(CompanyService.PersonalService));
                employeeServiceHost.Closed += Host_Closed;
                employeeServiceHost.Opened += Host_Opened;
                employeeServiceHost.Open();

                //helloServiceHost.Close();
                Console.ReadKey();
            }
        }

        private static void Host_Closed(object sender, EventArgs e)
        {
            // Sender as ServiceHost
            if (sender is ServiceHost)
            {
                Console.WriteLine("Host with service **_{0}_** closed at______{1}", (sender as ServiceHost).Description.Name, DateTime.Now);
            }
        }

        public static void Host_Opened(object sender, EventArgs e)
        {
            if (sender is ServiceHost)
            {
                Console.WriteLine("Host with service **_{0}_** opened at______{1}", (sender as ServiceHost).Description.Name, DateTime.Now);
            }
            // Console.WriteLine("Host opened at_____" + DateTime.Now);
        }
    }
}

