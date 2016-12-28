using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    DataTable dt;
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnnm_Click(object sender, EventArgs e)
    {
        con.Open();
        cmd = new SqlCommand("select * from userdata where fnm=@nm",con);
        cmd.Parameters.AddWithValue("@nm",txtnm.Text);
        dr = cmd.ExecuteReader();
        while(dr.Read())
        {
            txtlnm.Text = dr["lnm"].ToString();
        }
        con.Close();
    }
}