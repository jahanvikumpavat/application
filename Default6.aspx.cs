using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default6 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            fillfetails();
        }
    }
    dal d = new dal();
    bal b = new bal();
    private void fillfetails()
    {
        DetailsView1.DataSource = d.select_country();
        DetailsView1.DataBind();
    }
    protected void DetailsView1_ItemDeleting(object sender, DetailsViewDeleteEventArgs e)
    {
        int id = Convert.ToInt16(DetailsView1.DataKey.Value);
        b.country_id = id;
        d.delete_COUNTRY(b);
        fillfetails();
    }
    protected void DetailsView1_ItemInserting(object sender, DetailsViewInsertEventArgs e)
    {
        TextBox cnm = (TextBox)DetailsView1.Rows[0].FindControl("TextBox2");
        CheckBox isactive = (CheckBox)DetailsView1.Rows[0].FindControl("CheckBox3");
        b.country_name = cnm.Text;
        b.isactivecountry = isactive.Checked;
        d.INSERT_COUNTRY(b);
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
        fillfetails();
    }
    protected void DetailsView1_ItemUpdating(object sender, DetailsViewUpdateEventArgs e)
    {
        int id = Convert.ToInt16(DetailsView1.DataKey[0].ToString());
        b.country_id = id;
        TextBox cnm = (TextBox)DetailsView1.Rows[0].FindControl("TextBox1");
        CheckBox isactive = (CheckBox)DetailsView1.Rows[0].FindControl("CheckBox2");
        b.country_name = cnm.Text;
        b.isactivecountry = isactive.Checked;
        d.update_COUNTRY(b);
        DetailsView1.ChangeMode(DetailsViewMode.ReadOnly);
        fillfetails();

    }
    protected void DetailsView1_ModeChanging(object sender, DetailsViewModeEventArgs e)
    {
        DetailsView1.ChangeMode(e.NewMode);
        fillfetails();
    }
    protected void DetailsView1_PageIndexChanging(object sender, DetailsViewPageEventArgs e)
    {
        DetailsView1.PageIndex = e.NewPageIndex;
        fillfetails();
    }
}