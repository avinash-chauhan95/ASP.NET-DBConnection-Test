using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default : System.Web.UI.Page
{
    protected void BtnTestConnection_Click(object sender, EventArgs e)
    {
        string connectionString = WebConfigurationManager.ConnectionStrings["mycon"].ConnectionString;

        using (SqlConnection con = new SqlConnection(connectionString))
        {
            try
            {
                con.Open();
                lblConnectionStatus.Text = "Connection successful!";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
            }
            catch (Exception ex)
            {
                lblConnectionStatus.Text = "Connection failed: " + ex.Message;
                lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}