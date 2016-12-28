using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            ddlcountryfill();
        }
    }
    dal d = new dal();
    bal b = new bal();
    private void ddlcountryfill()
    {
        DropDownList1 = classdropdownlist.ddlfill(DropDownList1, d.select_country(), new string[] { "country_name", "Id" });
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        b.refcountry_id = Convert.ToInt16(DropDownList1.SelectedValue);
        DropDownList2 = classdropdownlist.ddlfill(DropDownList2, d.select_state(b), new string[] { "state_name", "S_Id" });
    }
}