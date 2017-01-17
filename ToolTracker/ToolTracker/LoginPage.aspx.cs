using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace ToolTracker
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\chadn\\Source\\Repos\\ToolTracker\\ToolTracker\\ToolTracker\\App_Data\\ToolTracker.mdf; Integrated Security = True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login Where userName='" + user_name.Text + "' and password='" + password.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if(dt.Rows[0][0].ToString() == "1")
            {
                Response.Redirect("LoginSuccess.aspx");
            }
            else
            {
                invalid_login.Visible = true;
            }
        }

        protected void cancel_button_Click(object sender, EventArgs e)
        {

        }
    }
}