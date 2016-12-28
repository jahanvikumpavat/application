using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            fillform();
        }
    }
    dal d = new dal();
    bal b = new bal();
    private void fillform()
    {
        FormView1.DataSource = d.select_country();
        FormView1.DataBind();
    }
    protected void FormView1_ItemInserting(object sender, FormViewInsertEventArgs e)
    {
        TextBox cnm = (TextBox)FormView1.FindControl("TextBox2");
        CheckBox isactive = (CheckBox)FormView1.FindControl("CheckBox3");
        b.country_name = cnm.Text;
        b.isactivecountry = isactive.Checked;
        d.INSERT_COUNTRY(b);
        FormView1.ChangeMode(FormViewMode.ReadOnly);
        fillform();
    }
    protected void FormView1_ItemDeleting(object sender, FormViewDeleteEventArgs e)
    {
        int id=Convert.ToInt32(FormView1.DataKey.Value);
        b.country_id=id;
        d.delete_COUNTRY(b);
        fillform();
    }
    protected void FormView1_ItemUpdating(object sender, FormViewUpdateEventArgs e)
    { 
        int id=Convert.ToInt16(FormView1.DataKey.Value);
        b.country_id=id;
        TextBox cnm=(TextBox)FormView1.FindControl("TextBox1");
        CheckBox isactive = (CheckBox)FormView1.FindControl("CheckBox2");
        b.country_name = cnm.Text;
        b.isactivecountry = isactive.Checked;
        d.update_COUNTRY(b);
        FormView1.ChangeMode(FormViewMode.ReadOnly);
        fillform();

    }
    protected void FormView1_ModeChanging(object sender, FormViewModeEventArgs e)
    {
        FormView1.ChangeMode(e.NewMode);
        fillform();

    }
    protected void FormView1_PageIndexChanging(object sender, FormViewPageEventArgs e)
    {
        FormView1.PageIndex = e.NewPageIndex;
        fillform();
    }
    protected void FormView1_ItemCommand(object sender, FormViewCommandEventArgs e)
    {
        switch(e.CommandName)
        {
            case "new":
                FormView1.ChangeMode(FormViewMode.Insert);
                break;

            case"edit":
                FormView1.ChangeMode(FormViewMode.Edit);
                fillform();
                 break;

            case "cancel":
                FormView1.ChangeMode(FormViewMode.ReadOnly);
                fillform();
                 break;
        }
    }
}