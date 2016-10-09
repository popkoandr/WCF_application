using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
namespace HelloServiceHost
{
    class Program
    {
        static void Main()
        {
            ServiceHost helloServiceHost = new ServiceHost(typeof(MyFirstService.HelloService));
            helloServiceHost.Closed += Host_Closed;
            helloServiceHost.Opened += Host_Opened;
            helloServiceHost.Open();

            ServiceHost companyServiceHost = new ServiceHost(typeof(CompanyService.CompanyService));
            companyServiceHost.Closed += Host_Closed;
            companyServiceHost.Opened += Host_Opened;
            companyServiceHost.Open();

            ServiceHost personalServiceHost = new ServiceHost(typeof(CompanyService.PersonalService));
            personalServiceHost.Closed += Host_Closed;
            personalServiceHost.Opened += Host_Opened;
            personalServiceHost.Open();
            





            //helloServiceHost.Close();
            Console.ReadKey();
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
