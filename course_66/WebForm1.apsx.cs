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

            Response.Write("Before changing the Gender of all male employees to Female");
            Response.Write("<br/>");

            //total count of male employees
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);
            Response.Write("<br/>");
            Response.Write("<br/>");

            //CONVERTS all "Male" employees to "Female"
            company["Male"] = "Female";

            Response.Write("After changing the Gender of all male employees to Female");
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Male:" + company["Male"]);
            Response.Write("<br/>");
            Response.Write("Total Employees with Gender = Female:" + company["Female"]);
        }
    }
}