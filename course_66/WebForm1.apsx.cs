using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Demo
{
    public partial class WebForm1 : System.Web.HttpUtility.Page
    {
        protected void Page_Load(object sender, EventArgs )
        {
            Company company = new Company();
            Response.Write("Name of Employee with Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8]);
            Response.Write("<br/>");
            Response.Write("<br/>");
            
            Response.Write("Changing names of employees with Id = 2,5,8");
            Response.Write("<br/>");
            company[2] = "Employee 2 Name Changed";
            company[5] = "Employee 5 Name Changed";
            company[8] = "Employee 8 Name Changed";

            Response.Write("Name of Employee with Id = 2: " + company[2]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 5: " + company[5]);
            Response.Write("<br/>");
            Response.Write("Name of Employee with Id = 8: " + company[8]);
        }
    }
}