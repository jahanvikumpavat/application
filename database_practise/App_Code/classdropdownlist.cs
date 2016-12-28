using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

/// <summary>
/// Summary description for classdropdownlist
/// </summary>
public class classdropdownlist
{
	public classdropdownlist()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static DropDownList ddlfill(DropDownList ddl,DataTable source,string[] fields)
    {
        ddl.Items.Clear();
        ddl.Items.Add("--Select--");
        ddl.AppendDataBoundItems = true;
        ddl.DataSource = source;
        ddl.DataTextField = fields[0];
        ddl.DataValueField = fields[1];
        ddl.DataBind();
        return ddl;
    }
}