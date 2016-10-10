using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.CompanyService;
//using WebApplication1.ServiceReferenceEmployeeService;

//using WebApplication1.EmployeeService;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HelloService2.HelloServiceClient client = new HelloService2.HelloServiceClient("BasicHttpBinding_IHelloService");
            Label1.Text = client.GetMessage(TextBox1.Text);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyPublicServiceClient publicServiceClient = new CompanyPublicServiceClient("BasicHttpBinding_ICompanyPublicService");
            Label2.Text = publicServiceClient.GetPublicInformation();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            CompanyService.CompanyConfidentialServiceClient confidentialServiceClient = new CompanyConfidentialServiceClient("NetTcpBinding_ICompanyConfidentialService");
            Label3.Text = confidentialServiceClient.GetConfidentialInformation();

        }

        protected void btnGetEmployee_Click(object sender, EventArgs e)
        {
            // EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            //Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));

            // txtName.Text = employee.Name;
            // txtGender.Text = employee.Gender;
            // txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            // lblMessage.Text = "Employee retrieved";

            EmployeeService.EmployeeServiceClient client =
       new EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee =
                client.GetEmployee(Convert.ToInt32(txtID.Text));

            if (employee.Type == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                txtAnnualSalary.Text =
                    ((EmployeeService.FullTimeEmployee)employee).AnnualSalary.ToString();
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                txtHourlyPay.Text =
                    ((EmployeeService.PartTimeEmployee)employee).HourlyPay.ToString();
                txtHoursWorked.Text =
                    ((EmployeeService.PartTimeEmployee)employee).HoursWorked.ToString();
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }
            ddlEmployeeType.SelectedValue = ((int)employee.Type).ToString();



            txtName.Text = employee.Name;
            txtGender.Text = employee.Gender;
            txtDateOfBirth.Text = employee.DateOfBirth.ToShortDateString();
            lblMessage.Text = "Employee retrieved";
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            // EmployeeServiceClient client = new EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            //Employee employee = client.GetEmployee(Convert.ToInt32(txtID.Text));

            // employee.Id = Convert.ToInt32(txtID.Text);
            // employee.Name = txtName.Text;
            // employee.Gender = txtGender.Text;
            // employee.DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text);

            // client.SaveEmployee(employee);

            // lblMessage.Text = "Employee saved";
            EmployeeService.EmployeeServiceClient client = new
        EmployeeService.EmployeeServiceClient();
            EmployeeService.Employee employee = null;

            if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
                == EmployeeService.EmployeeType.FullTimeEmployee)
            {
                employee = new EmployeeService.FullTimeEmployee
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = EmployeeService.EmployeeType.FullTimeEmployee,
                    AnnualSalary = Convert.ToInt32(txtAnnualSalary.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else if (((EmployeeService.EmployeeType)Convert.ToInt32(ddlEmployeeType.SelectedValue))
                == EmployeeService.EmployeeType.PartTimeEmployee)
            {
                employee = new EmployeeService.PartTimeEmployee
                {
                    Id = Convert.ToInt32(txtID.Text),
                    Name = txtName.Text,
                    Gender = txtGender.Text,
                    DateOfBirth = Convert.ToDateTime(txtDateOfBirth.Text),
                    Type = EmployeeService.EmployeeType.PartTimeEmployee,
                    HourlyPay = Convert.ToInt32(txtHourlyPay.Text),
                    HoursWorked = Convert.ToInt32(txtHoursWorked.Text),
                };
                client.SaveEmployee(employee);
                lblMessage.Text = "Employee saved";
            }
            else
            {
                lblMessage.Text = "Please select Employee Type";
            }
        }

        protected void ddlEmployeeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlEmployeeType.SelectedValue == "-1")
            {
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else if (ddlEmployeeType.SelectedValue == "1")
            {
                trAnnualSalary.Visible = true;
                trHourlPay.Visible = false;
                trHoursWorked.Visible = false;
            }
            else
            {
                trAnnualSalary.Visible = false;
                trHourlPay.Visible = true;
                trHoursWorked.Visible = true;
            }
        }
    }
}