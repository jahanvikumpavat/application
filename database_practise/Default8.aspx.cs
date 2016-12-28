using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            filllistview();
        }
    }
    dal d = new dal();
    bal b = new bal();
    private void filllistview()
    {
        ListView1.DataSource = d.select_country();
        ListView1.DataBind();
    }


    protected void ListView1_ItemCanceling(object sender, ListViewCancelEventArgs e)
    {
        ListView1.EditIndex = -1;
        filllistview();
    }
    protected void ListView1_ItemDeleting(object sender, ListViewDeleteEventArgs e)
    {
        int id = Convert.ToInt16(ListView1.DataKeys[e.ItemIndex].Value);
        b.country_id = id;
        d.delete_COUNTRY(b);
        filllistview();
    }
    protected void ListView1_ItemInserted(object sender, ListViewInsertedEventArgs e)
    {

    }
    protected void ListView1_ItemUpdating(object sender, ListViewUpdateEventArgs e)
    {
        int id = Convert.ToInt16(ListView1.DataKeys[e.ItemIndex].Value);
        b.country_id = id;
        TextBox countryname = (TextBox)ListView1.Items[e.ItemIndex].FindControl("TextBox1");
        CheckBox chk = (CheckBox)ListView1.Items[e.ItemIndex].FindControl("CheckBox1");
        b.country_name = countryname.Text;
        b.isactivecountry = chk.Checked;
        d.update_COUNTRY(b);
        ListView1.EditIndex = -1;
        filllistview();
    }
    protected void ListView1_ItemEditing(object sender, ListViewEditEventArgs e)
    {
        ListView1.EditIndex = e.NewEditIndex;
        filllistview();
    }
}