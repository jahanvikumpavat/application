using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default9 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            fillgrid();
        }
    }

    private void fillgrid()
    {
        DataTable dt = new DataTable();
        dt.Columns.Add("student_no", typeof(int));
        dt.Columns.Add("student_name",typeof(string));

        DataRow dr = dt.NewRow();

        dr[0] = 1;
        dr[1] = "janvi";
        dt.Rows.Add(dr);

         dr = dt.NewRow();

        dr[0] = 2;
        dr[1] = "tanvi";
        dt.Rows.Add(dr);

         dr = dt.NewRow();

        dr[0] = 3;
        dr[1] = "kirit";
        dt.Rows.Add(dr);

        GridView1.DataSource = dt;
        GridView1.DataBind();
    
    }
}