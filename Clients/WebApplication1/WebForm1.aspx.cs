using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.CompanyService;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloService2.HelloServiceClient client = new  HelloService2.HelloServiceClient("BasicHttpBinding_IHelloService");
            Label1.Text = client.GetMessage(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyPublicServiceClient publicServiceClient  = new CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            Label2.Text = publicServiceClient.GetPublicInformation();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyConfidentialServiceClient confidentialServiceClient = new CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            Label3.Text = confidentialServiceClient.GetConfidentialInformation();

        }
    }
}