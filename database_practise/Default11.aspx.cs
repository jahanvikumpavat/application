using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.DataVisualization.Charting;
using System.Web.UI.WebControls;

public partial class Default11 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       if(!IsPostBack)
       {
           bindchart();
       }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
       // Chart1.Series["Series1"].ChartType = (SeriesChartType)Enum.Parse(typeof(SeriesChartType), DropDownList1.SelectedValue);
       Chart1.Series["Series1"].ChartType=(SeriesChartType)Enum.Parse(typeof(SeriesChartType),DropDownList1.SelectedValue);
        bindchart();
    }

    private void bindchart()
    {
        Array value = Enum.GetValues(typeof(SeriesChartType));
        DropDownList1.Items.Add("--Select chart type--");

        foreach (SeriesChartType item in value)
        {
            DropDownList1.Items.Add(item.ToString());
        }
    }

    protected void Chart1_DataBound(object sender, EventArgs e)
    {
      //  Chart1.DataManipulator.Sort(PointSortOrder.Ascending, "y", "Series1");
        Chart1.DataManipulator.FilterTopN(4, "Series1", "Series1", "y", true);
    }
}