using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            fillgrod();
        }
    }

    private void fillgrod()
    {
        GridView1.DataSource = d.select_country();
        GridView1.DataBind();
    }
    bal b = new bal();
    dal d = new dal();
    protected void Button1_Click(object sender, EventArgs e)
    {
        b.country_name = TextBox1.Text;
        b.isactivecountry = CheckBox1.Checked;
        d.INSERT_COUNTRY(b);
        fillgrod();
        
    }
    protected void GridView1_RowDeleted(object sender, GridViewDeletedEventArgs e)
    {

    }
    protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
    {
        int cid = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
        b.country_id = cid;
        d.delete_COUNTRY(b);
        fillgrod();
    }
    protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
    {
        GridViewRow fr = GridView1.Rows[e.RowIndex];
        TextBox cnm = (TextBox)fr.Cells[1].Controls[0];
        b.country_name = cnm.Text;
        b.isactivecountry = ((CheckBox)fr.Cells[2].Controls[0]).Checked;
        int cid = Convert.ToInt16(GridView1.DataKeys[e.RowIndex].Value);
        b.country_id = cid;
        d.update_COUNTRY(b);
        GridView1.EditIndex = -1;
        fillgrod();
      

    }
    protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
    {
        GridView1.EditIndex = e.NewEditIndex;
        fillgrod();
    }
    protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
    {
        GridView1.EditIndex = -1;
        fillgrod();
    }
}