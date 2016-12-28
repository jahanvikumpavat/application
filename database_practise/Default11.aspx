<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default11.aspx.cs" Inherits="Default11" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1" OnDataBound="Chart1_DataBound">
            <Series>
                <asp:Series Name="Series1" XValueMember="Country_name" YValueMembers="Population"></asp:Series>
            </Series>
            <ChartAreas>
                <asp:ChartArea Name="ChartArea1" Area3DStyle-Enable3D="true">

                </asp:ChartArea>
            </ChartAreas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:topsConnectionString %>" SelectCommand="SELECT [Country_name], [Population] FROM [Table]"></asp:SqlDataSource>
        <br />
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
    </div>
    </form>
</body>
</html>
