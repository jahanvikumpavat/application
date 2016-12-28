using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            filllist();
        }
    }
    dal d = new dal();
    bal b = new bal();
    private void filllist()
    {
        DataList1.DataSource = d.select_country();
        DataList1.DataBind();
    }
    protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = -1;
        filllist();
    }
    protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt16(DataList1.DataKeys[e.Item.ItemIndex].ToString());
        b.country_id = id;
        d.delete_COUNTRY(b);
        filllist();
    }
    protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
    {
        DataList1.EditItemIndex = e.Item.ItemIndex;
        filllist();
    }
    protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
    {
        int id = Convert.ToInt16(DataList1.DataKeys[e.Item.ItemIndex].ToString());
        b.country_id = id;
        TextBox cnm = (TextBox)DataList1.Items[e.Item.ItemIndex].FindControl("TextBox1");
        CheckBox isactive = (CheckBox)DataList1.Items[e.Item.ItemIndex].FindControl("CheckBox1");

        b.country_name = cnm.Text;
        b.isactivecountry = isactive.Checked;

        d.update_COUNTRY(b);
        DataList1.EditItemIndex = -1;
        filllist();
    }
}