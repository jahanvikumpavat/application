using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default2 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("select count(id) from userdata",con);
        int r =Convert.ToInt16(  cmd.ExecuteScalar());
        con.Close();

        Label1.Text=r.ToString();
    }
}